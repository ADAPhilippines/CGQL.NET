using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CGQL.NET.Server.Data;
using GreenDonut;
using HotChocolate.DataLoader;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using CGQL.NET.Models;

namespace CGQL.NET.Server.GraphQL.DataLoaders
{
    public class TransactionByHashDataLoader : BatchDataLoader<string, Transaction>
    {
        private readonly IDbContextFactory<CardanoDbContext> _dbContextFactory;

        public TransactionByHashDataLoader(
            IBatchScheduler batchScheduler,
            IDbContextFactory<CardanoDbContext> dbContextFactory)
            : base(batchScheduler)
        {
            _dbContextFactory = dbContextFactory ??
                throw new ArgumentNullException(nameof(dbContextFactory));
        }

        protected override async Task<IReadOnlyDictionary<string, Transaction>> LoadBatchAsync(
            IReadOnlyList<string> keys,
            CancellationToken cancellationToken)
        {
            await using CardanoDbContext dbContext =
                _dbContextFactory.CreateDbContext();
                
            var hashes = keys.Select(k => CGQLHelpers.HexStringToByteArray(k));

            var txesDbSet = dbContext.Txes
                .Include(tx => tx.TxOuts)
                .Include(tx => tx.InTxIns)
                    .ThenInclude(i => i.OutTx)
                    .ThenInclude(o => o.TxOuts);

            var txes = await (from tx in txesDbSet
                where hashes.Contains(tx.Hash)
                select tx).ToListAsync(cancellationToken);

            var transactions = TransactionDataLoaderHelpers.BuildTransactionsfromTxes(txes);

            return transactions.ToDictionary(o => o.Hash);
        }
    }
}

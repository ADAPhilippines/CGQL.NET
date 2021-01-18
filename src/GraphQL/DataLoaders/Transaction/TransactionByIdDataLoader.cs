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
    public class TransactionByIdDataLoader : BatchDataLoader<long, Transaction>
    {
        private readonly IDbContextFactory<CardanoDbContext> _dbContextFactory;

        public TransactionByIdDataLoader(
            IBatchScheduler batchScheduler,
            IDbContextFactory<CardanoDbContext> dbContextFactory)
            : base(batchScheduler)
        {
            _dbContextFactory = dbContextFactory ??
                throw new ArgumentNullException(nameof(dbContextFactory));
        }

        protected override async Task<IReadOnlyDictionary<long, Transaction>> LoadBatchAsync(
            IReadOnlyList<long> keys,
            CancellationToken cancellationToken)
        {
            await using CardanoDbContext dbContext =
                _dbContextFactory.CreateDbContext();

            var txesDbSet = dbContext.Txes
                .Include(tx => tx.TxOuts)
                .Include(tx => tx.InTxIns)
                    .ThenInclude(i => i.OutTx)
                    .ThenInclude(o => o.TxOuts);

            var txes = await (from tx in txesDbSet
                where keys.Contains(tx.Id)
                select tx).ToListAsync(cancellationToken);

            var transactions = TransactionDataLoaderHelpers.BuildTransactionsfromTxes(txes);

            var result = new Dictionary<long, Transaction>();

            foreach(var tx in txes)
            {
                result.Add(tx.Id, transactions.Where(t => t.Hash == CGQLHelpers.ByteArrayToHexString(tx.Hash)).First());
            }

            return result;
        }
    }
}

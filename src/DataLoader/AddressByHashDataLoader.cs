using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CGQL.NET.Server.Data;
using GreenDonut;
using HotChocolate.DataLoader;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using CGQL.NET.Server.Data.Entities;

namespace CGQL.NET.Server
{
    public class AddressDataLoader : BatchDataLoader<string, Address>
    {
        private readonly IDbContextFactory<CardanoDbContext> _dbContextFactory;

        public AddressDataLoader(
            IBatchScheduler batchScheduler,
            IDbContextFactory<CardanoDbContext> dbContextFactory)
            : base(batchScheduler)
        {
            _dbContextFactory = dbContextFactory ??
                throw new ArgumentNullException(nameof(dbContextFactory));
        }

        protected override async Task<IReadOnlyDictionary<string, Address>> LoadBatchAsync(
            IReadOnlyList<string> keys,
            CancellationToken cancellationToken)
        {
            await using CardanoDbContext dbContext =
                _dbContextFactory.CreateDbContext();
            
            
            var txIds = await dbContext.TxOuts.Include(o => o.Tx)
                .Where(o => keys.Contains(o.Address))
                .GroupBy(o => o.TxId)
                .Select(g => g.Key).ToListAsync(cancellationToken);
            
            var txes = await dbContext.Txes
                .Include(tx => tx.InTxIns)
                    .ThenInclude(txIn => txIn.OutTx)
                        .ThenInclude(tx2 => tx2.InTxIns)
                .Include(tx => tx.TxOuts)
                .Where(tx => txIds.Contains(tx.Id)).ToListAsync(cancellationToken);
           
                // .AsQueryable()
                // .Include(tx => tx.InTxIns)
                // .Include(tx => tx.OutTxIns)

            var txOuts = await dbContext.TxOuts.Where(o => keys.Contains(o.Address)).ToListAsync(cancellationToken);
            return txOuts.GroupBy(o => o.Address).Select(o => new Address(o.Key, txOuts.Count)).ToDictionary(o => o.Hash);
        }
    }
}

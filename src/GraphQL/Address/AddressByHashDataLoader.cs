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

namespace GCQL.NET.Server.GraphQL
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
            
            // var txOuts = await dbContext.TxOuts
            //     .Where(o => keys.Contains(o.Address))
            //     .GroupJoin(
            //         dbContext.TxIns, o => new {o.TxId, TxIndex = o.Index},
            //         i => new {TxId = i.TxOutId, TxIndex = i.TxOutIndex}, 
            //         (o, i) => new {o.Address, o.Value, In = i})
            //     .DefaultIfEmpty()
            //     .ToListAsync(cancellationToken);

            var txOuts = await (from o in dbContext.TxOuts
                where keys.Contains(o.Address)
                join i in dbContext.TxIns on new {o.TxId, TxIndex = o.Index} equals new {TxId = i.TxOutId, TxIndex = i.TxOutIndex}  into gj
                from tx in gj.DefaultIfEmpty()
                select new { o.Address, o.Value, TxInId = tx != null ? tx.TxInId : 0L, o.TxId }).ToListAsync(cancellationToken);
            // Query To Sum All Value
            // Query To Count Transactions

            return txOuts.GroupBy(o => o.Address).Select(o => 
                    new Address(
                        o.Key,
                        txOuts
                            .Where(o1 => o1.Address == o.Key && o1.TxInId > 0)
                            .GroupBy(o1 => o1.TxId)
                            .Select(o1 => o1.Key)
                            .ToList()
                            .Concat(
                                txOuts.Where(o1 => o1.Address == o.Key && o1.TxInId > 0)
                                .GroupBy(o1 => o1.TxInId)
                                .Select(o1 => o1.Key))
                            .Distinct()
                            .Count(),
                        (long)txOuts.Where(o1 => o1.Address == o.Key && o1.TxInId == 0).Sum(o1 => o1.Value))
                ).ToDictionary(o => o.Hash);
        }
    }
}

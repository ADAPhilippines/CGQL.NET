using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CGQL.NET.Server.Data;
using GreenDonut;
using HotChocolate.DataLoader;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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

            var txOuts = await dbContext.TxOuts.Where(o => keys.Contains(o.Address)).ToListAsync(cancellationToken: cancellationToken);
            return txOuts.GroupBy(o => o.Address).Select(o => new Address(o.Key, txOuts.Count)).ToDictionary(o => o.Hash);
        }
    }
}

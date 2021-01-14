using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CGQL.NET.Server.Data;
using CGQL.NET.Server.Data.Entities;
using GreenDonut;
using HotChocolate.DataLoader;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CGQL.NET.Server.GraphQL.DataLoaders
{
    public class BlockByNoDataLoader : BatchDataLoader<int?, Block>
    {
        private readonly IDbContextFactory<CardanoDbContext> _dbContextFactory;

        public BlockByNoDataLoader(
            IBatchScheduler batchScheduler,
            IDbContextFactory<CardanoDbContext> dbContextFactory)
            : base(batchScheduler)
        {
            _dbContextFactory = dbContextFactory ??
                throw new ArgumentNullException(nameof(dbContextFactory));
        }

        protected override async Task<IReadOnlyDictionary<int?, Block>> LoadBatchAsync(
            IReadOnlyList<int?> keys,
            CancellationToken cancellationToken)
        {
            await using CardanoDbContext dbContext =
                _dbContextFactory.CreateDbContext();

            return await dbContext.Blocks
                .Where(b => keys.Contains(b.BlockNo))
                .ToDictionaryAsync(t => t.BlockNo, cancellationToken);
        }
    }
}
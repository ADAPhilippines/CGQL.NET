using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CGQL.NET.Server.Data;
using GreenDonut;
using HotChocolate.DataLoader;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CGQL.NET.Server.GraphQL.DataLoaders
{
    public class BlockByHashDataLoader : BatchDataLoader<string, Models.Block>
    {
        private readonly IDbContextFactory<CardanoDbContext> _dbContextFactory;

        public BlockByHashDataLoader(
            IBatchScheduler batchScheduler,
            IDbContextFactory<CardanoDbContext> dbContextFactory)
            : base(batchScheduler)
        {
            _dbContextFactory = dbContextFactory ??
                throw new ArgumentNullException(nameof(dbContextFactory));
        }

        protected override async Task<IReadOnlyDictionary<string, Models.Block>> LoadBatchAsync(
            IReadOnlyList<string> keys,
            CancellationToken cancellationToken)
        {
            await using CardanoDbContext dbContext =
                _dbContextFactory.CreateDbContext();

            var hashes = keys.Select(k => CGQLHelpers.HexStringToByteArray(k));

            var dbBlocks = await (from block in dbContext.Blocks
                where hashes.Contains(block.Hash)
                select block).ToListAsync(cancellationToken);

            var blocks = BlockDataLoaderHelpers.BuildBlocksfromDbBlocks(dbBlocks);

            return blocks.ToDictionary(b => b.Hash);
        }
    }
}
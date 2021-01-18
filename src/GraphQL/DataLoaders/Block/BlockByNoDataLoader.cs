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
    public class BlockByNoDataLoader : BatchDataLoader<int, Models.Block>
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

        protected override async Task<IReadOnlyDictionary<int, Models.Block>> LoadBatchAsync(
            IReadOnlyList<int> keys,
            CancellationToken cancellationToken)
        {
            await using CardanoDbContext dbContext =
                _dbContextFactory.CreateDbContext();

            var dbBlocks = await (from block in dbContext.Blocks
                where keys.Contains(block.BlockNo ?? 0)
                select block).ToListAsync(cancellationToken);

            var blocks = BlockDataLoaderHelpers.BuildBlocksfromDbBlocks(dbBlocks);

            var result = new Dictionary<int, Models.Block>();

            foreach(var block in dbBlocks)
            {
                if(block != null)
                {
                    result.Add(block.BlockNo ?? 0, blocks.Where(t => t.Hash == CGQLHelpers.ByteArrayToHexString(block.Hash)).First());
                }
            }

            return result;
        }
    }
}
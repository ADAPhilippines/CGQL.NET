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
    public class BlockByIdDataLoader : BatchDataLoader<long, Models.Block>
    {
        private readonly IDbContextFactory<CardanoDbContext> _dbContextFactory;

        public BlockByIdDataLoader(
            IBatchScheduler batchScheduler,
            IDbContextFactory<CardanoDbContext> dbContextFactory)
            : base(batchScheduler)
        {
            _dbContextFactory = dbContextFactory ??
                throw new ArgumentNullException(nameof(dbContextFactory));
        }

        protected override async Task<IReadOnlyDictionary<long, Models.Block>> LoadBatchAsync(
            IReadOnlyList<long> keys,
            CancellationToken cancellationToken)
        {
            await using CardanoDbContext dbContext =
                _dbContextFactory.CreateDbContext();

            var dbBlocks = await (from block in dbContext.Blocks
                where keys.Contains(block.Id)
                select block).ToListAsync(cancellationToken);

            var blocks = BlockDataLoaderHelpers.BuildBlocksfromDbBlocks(dbBlocks);

            var result = new Dictionary<long, Models.Block>();

            foreach(var block in dbBlocks)
            {
                result.Add(block.Id, blocks.Where(t => t.Hash == CGQLHelpers.ByteArrayToHexString(block.Hash)).First());
            }

            return result;
        }
    }
}
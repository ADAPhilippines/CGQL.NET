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

            var blocks = await (from block in dbContext.Blocks
                where hashes.Contains(block.Hash)
                select block).ToListAsync(cancellationToken);

            return blocks.GroupBy(b => b.Hash).Select(blockGroup =>
            {
                var hash = string.Concat(blockGroup.Key.Select(b1 => b1.ToString("x2")));
                var block = blockGroup.First();
                var merkelRoot = block.MerkelRoot != null ? string.Concat(block.MerkelRoot.Select(b1 => b1.ToString("x2"))) : default!;
                return new Models.Block(hash,
                    block.BlockNo ?? 0,
                    block.EpochNo ?? 0,
                    block.SlotNo ?? 0,
                    default!,
                    default!,
                    block.Size,
                    block.Time,
                    merkelRoot,
                    default!
                );
            }).ToDictionary(o => o.Hash);
        }
    }
}
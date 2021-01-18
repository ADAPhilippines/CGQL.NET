using System.Collections.Generic;
using System.Linq;
using CGQL.NET.Models;
using CGQL.NET.Server.Data.Entities;
using Block = CGQL.NET.Server.Data.Entities.Block;

namespace CGQL.NET.Server.GraphQL.DataLoaders
{
    static class BlockDataLoaderHelpers
    {
        public static IEnumerable<Models.Block> BuildBlocksfromDbBlocks(IEnumerable<Block> blocks)
        {
            return blocks.GroupBy(b => b.Hash).Select(blockGroup =>
            {
                var hash = string.Concat(blockGroup.Key.Select(b1 => b1.ToString("x2")));
                var block = blockGroup.First();
                var merkelRoot = block.MerkelRoot != null ? string.Concat(block.MerkelRoot.Select(b1 => b1.ToString("x2"))) : default!;
                var previousBlock = new Models.Block(default!, (int)(block?.PreviousId ?? 0), 
                    default!, default!, default!, default!, default!, default!, default!, default!);

                var nextBlock = new Models.Block(default!, (block?.BlockNo ?? 0) + 1,
                    default!, default!, default!, default!, default!, default!, default!, default!);
                
                var tx = new Transaction(default!, default!, default!, 
                    new Models.Block(default!, (int)(block?.Id ?? 0), 
                        default!,  default!, default!, default!, default!, default!, default!, default!),
                    default!, default!, default!, default!, default!, default!, default!);
                
                var transactions = new List<Transaction> { tx }; 
                return new Models.Block(hash,
                    block.BlockNo ?? 0,
                    block.EpochNo ?? 0,
                    block.SlotNo ?? 0,
                    previousBlock,
                    nextBlock,
                    block.Size,
                    block.Time,
                    merkelRoot,
                    transactions
                );
            });
        } 
    }
}
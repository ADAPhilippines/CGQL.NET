using System.Threading;
using System.Threading.Tasks;
using CGQL.NET.Models;
using CGQL.NET.Server.Data;
using CGQL.NET.Server.GraphQL.DataLoaders;
using HotChocolate;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CGQL.NET.Server.GraphQL
{
    public class BlockResolvers
    {
        public async Task<Block> GetPreviousBlockAsync(
            Block block,
            BlockByIdDataLoader blockById,
            CancellationToken cancellationToken)
        {
            var blockId = (long) block.PreviousBlock.BlockNo;

            return await blockById.LoadAsync(blockId, cancellationToken);
        }

        public async Task<Block> GetNextBlockAsync(
            Block block,
            BlockByNoDataLoader blockByNo,
            CancellationToken cancellationToken)
        {
            var blockNo = block.NextBlock.BlockNo;

            return await blockByNo.LoadAsync(blockNo, cancellationToken);
        }

        public async Task<IEnumerable<Transaction>> GetTransactionsAsync(
            Block block,
            [ScopedService] CardanoDbContext dbContext,
            TransactionByIdDataLoader transactionById,
            CancellationToken cancellationToken)
        {
            var blockId = block.Transactions.First().Block.BlockNo;

            var txIds = await (from tx in dbContext.Txes 
                where tx.BlockId == blockId
                select tx.Id).ToArrayAsync(cancellationToken);

            return await transactionById.LoadAsync(txIds, cancellationToken);
        }
    }
}
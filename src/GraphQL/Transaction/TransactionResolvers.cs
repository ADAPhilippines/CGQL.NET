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
    public class TransactionResolvers
    {
        public async Task<Block> GetBlockAsync(
            Transaction transaction,
            BlockByIdDataLoader blockById,
            CancellationToken cancellationToken)
        {
            var blockId = long.Parse(transaction.Block.Hash);

            return await blockById.LoadAsync(blockId, cancellationToken);
        }

        public async Task<IEnumerable<TransactionMetadata>> GetMetadataAsync(
            Transaction transaction,
            [ScopedService] CardanoDbContext dbContext,
            TransactionMetadataByIdDataLoader transactionMetadataById,
            CancellationToken cancellationToken)
        {
            var txId = transaction.Metadata.First().Key;

            var metaIds =  await (from meta in dbContext.TxMetadata
                where meta.TxId == txId
                select meta.Id ).ToArrayAsync(cancellationToken);

            return await transactionMetadataById.LoadAsync(metaIds, cancellationToken);
        }
    }
}
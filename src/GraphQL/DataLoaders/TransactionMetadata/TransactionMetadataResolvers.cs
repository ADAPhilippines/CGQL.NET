using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using CGQL.NET.Models;
using CGQL.NET.Server.GraphQL.DataLoaders;

namespace CGQL.NET.Server.GraphQL
{
    public class TransactionMetaResolvers
    {
        public async Task<Transaction> GetTransactionsAsync(
            TransactionMetadata transactionMetadata,
            TransactionByIdDataLoader transactionById,
            CancellationToken cancellationToken)
        {
            var txId = long.Parse(transactionMetadata.Transaction.Hash);
            return await transactionById.LoadAsync(txId, cancellationToken);
        }
    }
}
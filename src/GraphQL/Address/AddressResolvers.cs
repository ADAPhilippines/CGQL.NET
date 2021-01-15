using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using CGQL.NET.Models;
using CGQL.NET.Server.GraphQL.DataLoaders;

namespace CGQL.NET.Server.GraphQL
{
    public class AddressResolvers
    {
        public async Task<IEnumerable<Transaction>> GetTransactionsAsync(
            Address address,
            TransactionByIdDataLoader transactionById,
            CancellationToken cancellationToken)
        {
            var txIds = address.Transactions.Select(tx => long.Parse(tx.Hash)).ToArray();
            return await transactionById.LoadAsync(txIds, cancellationToken);
        }
    }
}
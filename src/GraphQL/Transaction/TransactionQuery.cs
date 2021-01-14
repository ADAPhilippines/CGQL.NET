using System.Threading;
using System.Threading.Tasks;
using CGQL.NET.Models;
using CGQL.NET.Server.GraphQL.DataLoaders;
using HotChocolate;
using HotChocolate.Types;

namespace CGQL.NET.Server.GraphQL
{
    [ExtendObjectType(Name = "Query")]
    public class TransactionQuery
    {
        public Task<Transaction> GetTransactionAsync(
            string hash,
            TransactionDataLoader dataLoader,
            CancellationToken cancellationToken) => dataLoader.LoadAsync(hash, cancellationToken);
    }
}
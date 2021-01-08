 using System.Threading;
 using System.Threading.Tasks;
using CGQL.NET.Models;
using CGQL.NET.Server;
using HotChocolate;
 using HotChocolate.Types;

namespace GCQL.NET.Server.GraphQL
{
    [ExtendObjectType(Name = "Query")]
    public class AddressQuery 
    {
        public Task<Address> GetAddressAsync(
            string hash,
            AddressDataLoader dataLoader,
            CancellationToken cancellationToken) => dataLoader.LoadAsync(hash, cancellationToken);
    }
}
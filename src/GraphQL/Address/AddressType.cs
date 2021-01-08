using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CGQL.NET.Models;
using CGQL.NET.Server.Data;
using GCQL.NET.Server.GraphQL;
using HotChocolate.Types;

namespace CGQL.NET.Server.GraphQL
{
    public class AddressType : ObjectType<Address>
    {
        protected override void Configure(IObjectTypeDescriptor<Address> descriptor)
        {
            descriptor
                .Field(t => t.Hash)
                .ResolveWith<AddressResolvers>(t => t.GetAddressAsync(default!, default!, default))
                .UseDbContext<CardanoDbContext>()
                .Name("addresses");
        }
        private class AddressResolvers
        {
            public async Task<IEnumerable<Address>> GetAddressAsync(
                Address address,
                AddressDataLoader addressByHash,
                CancellationToken cancellationToken)
            {
                return await addressByHash.LoadAsync(new string[] { address.Hash }, cancellationToken);
            }
        }
    }
}
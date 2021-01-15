using CGQL.NET.Models;
using CGQL.NET.Server.Data;
using HotChocolate.Types;

namespace CGQL.NET.Server.GraphQL
{
    public class AddressType : ObjectType<Address>
    {
        protected override void Configure(IObjectTypeDescriptor<Address> descriptor)
        {
            descriptor
                .Field(t => t.Transactions)
                .ResolveWith<AddressResolvers>(t => t.GetTransactionsAsync(default!, default!, default!))
                .UseDbContext<CardanoDbContext>()
                .Name("transactions");
        }
    }
}

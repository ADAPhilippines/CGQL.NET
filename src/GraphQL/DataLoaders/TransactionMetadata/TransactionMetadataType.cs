using CGQL.NET.Models;
using CGQL.NET.Server.Data;
using HotChocolate.Types;

namespace CGQL.NET.Server.GraphQL
{
    public class TransactionMetadataType : ObjectType<TransactionMetadata>
    {
        protected override void Configure(IObjectTypeDescriptor<TransactionMetadata> descriptor)
        {
            descriptor
                .Field(t => t.Transaction)
                .ResolveWith<TransactionMetaResolvers>(t => t.GetTransactionsAsync(default!, default!, default!))
                .UseDbContext<CardanoDbContext>()
                .Name("transaction");
        }
    }
}

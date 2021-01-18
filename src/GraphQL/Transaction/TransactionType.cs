using CGQL.NET.Models;
using CGQL.NET.Server.Data;
using HotChocolate.Types;

namespace CGQL.NET.Server.GraphQL
{
    public class TransactionType : ObjectType<Transaction>
    {
        protected override void Configure(IObjectTypeDescriptor<Transaction> descriptor)
        {
            descriptor
                .Field(t => t.Block)
                .ResolveWith<TransactionResolvers>(t => t.GetBlockAsync(default!, default!, default!))
                .UseDbContext<CardanoDbContext>()
                .Name("block");

            descriptor
                .Field(t => t.Metadata)
                .ResolveWith<TransactionResolvers>(t => t.GetMetadataAsync(default!, default!, default!, default!))
                .UseDbContext<CardanoDbContext>()
                .Name("metadata");
        }
    }
}

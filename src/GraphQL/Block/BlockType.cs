using CGQL.NET.Models;
using CGQL.NET.Server.Data;
using HotChocolate.Types;

namespace CGQL.NET.Server.GraphQL
{
    public class BlockType : ObjectType<Block>
    {
        protected override void Configure(IObjectTypeDescriptor<Block> descriptor)
        {
            descriptor
                .Field(t => t.PreviousBlock)
                .ResolveWith<BlockResolvers>(t => t.GetPreviousBlockAsync(default!, default!, default!))
                .UseDbContext<CardanoDbContext>()
                .Name("previousBlock");

            descriptor
                .Field(t => t.NextBlock)
                .ResolveWith<BlockResolvers>(t => t.GetNextBlockAsync(default!, default!, default!))
                .UseDbContext<CardanoDbContext>()
                .Name("nextBlock");

            descriptor
                .Field(t => t.Transactions)
                .ResolveWith<BlockResolvers>(t => t.GetTransactionsAsync(default!, default!, default!, default!))
                .UseDbContext<CardanoDbContext>()
                .Name("transactions");
        }
    }
}

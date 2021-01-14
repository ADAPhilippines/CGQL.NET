using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CGQL.NET.Models;
using CGQL.NET.Server.Data;
using CGQL.NET.Server.GraphQL.DataLoaders;
using HotChocolate;
using HotChocolate.Types;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace CGQL.NET.Server.GraphQL
{
    public class AddressType : ObjectType<Address>
    {
        protected override void Configure(IObjectTypeDescriptor<Address> descriptor)
        {
            descriptor
                .Field(t => t.Transactions)
                .ResolveWith<AddressResolvers>(t => t.GetTransactionsAsync(default!, default!, default!, default))
                .UseDbContext<CardanoDbContext>()
                .Name("transactions");
        }
        private class AddressResolvers
        {
            public async Task<IEnumerable<Transaction>> GetTransactionsAsync(
                Address address,
                [ScopedService] CardanoDbContext dbContext,
                TransactionDataLoader transactionByHash,
                CancellationToken cancellationToken)
            {
                var txOuts = await (from o in dbContext.TxOuts.Include(o => o.Tx) 
                    where o.Address == address.Hash
                    join i in dbContext.TxIns.Include(i => i.InTx) on new {o.TxId, TxIndex = o.Index} equals new {TxId = i.TxOutId, TxIndex = i.TxOutIndex}  into gj
                    from tx in gj.DefaultIfEmpty()
                    select new { TxInId = tx != null ? tx.InTx.Hash : new byte[1], TxId = o.Tx.Hash }
                ).ToListAsync(cancellationToken);

                var txIds = txOuts
                    .GroupBy(o1 => String.Concat(o1.TxId.Select(b => b.ToString("x2"))))
                    .Select(o1 => o1.Key)
                    .ToList()
                    .Concat(
                        txOuts.GroupBy(o1 => String.Concat(o1.TxInId.Select(b => b.ToString("x2"))))
                        .Select(o1 => o1.Key))
                    .Distinct()
                    .Where(o1 => o1.Length > 2)
                    .ToArray();

                return await transactionByHash.LoadAsync(txIds, cancellationToken);
            }
        }
    }
}

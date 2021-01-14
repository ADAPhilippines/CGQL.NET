using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CGQL.NET.Server.Data;
using GreenDonut;
using HotChocolate.DataLoader;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using CGQL.NET.Models;
using System.Text;

namespace CGQL.NET.Server.GraphQL.DataLoaders
{
    public class TransactionDataLoader : BatchDataLoader<string, Transaction>
    {
        private readonly IDbContextFactory<CardanoDbContext> _dbContextFactory;

        public TransactionDataLoader(
            IBatchScheduler batchScheduler,
            IDbContextFactory<CardanoDbContext> dbContextFactory)
            : base(batchScheduler)
        {
            _dbContextFactory = dbContextFactory ??
                throw new ArgumentNullException(nameof(dbContextFactory));
        }

        protected override async Task<IReadOnlyDictionary<string, Transaction>> LoadBatchAsync(
            IReadOnlyList<string> keys,
            CancellationToken cancellationToken)
        {
            await using CardanoDbContext dbContext =
                _dbContextFactory.CreateDbContext();

            //Convert string Hashes into byte[]
            //source: https://forums.asp.net/t/1767179.aspx?Convert+from+a+hex+string+to+a+byte+array+in+C+
            var hashes = keys.Select(k => Enumerable.Range(0, k.Length)
                    .Where(x => x % 2 == 0)
                    .Select(x => Convert.ToByte(k.Substring(x, 2), 16))
                    .ToArray());

            var txesDbSet = dbContext.Txes
                .Include(tx => tx.Block)
                .Include(tx => tx.TxOuts)
                .Include(tx => tx.InTxIns)
                    .ThenInclude(i => i.OutTx)
                    .ThenInclude(o => o.TxOuts);

            var txes = await (from tx in txesDbSet
                              where hashes.Contains(tx.Hash)
                              select tx
            ).ToListAsync(cancellationToken);

            return txes.GroupBy(tx => tx.Hash).Select(txGroup =>
            {
                var hash = String.Concat(txGroup.Key.Select(b => b.ToString("x2")));
                var tx = txGroup.First();
                return new Transaction(
                    hash,
                    tx.InTxIns.OrderBy(i => i.OutTx.Id).Select(i =>
                    {
                        var txOut = i.OutTx.TxOuts.ToList()[i.TxOutIndex];
                        return new TxOutput(txOut.Address,
                            (long)txOut.Value,
                            txOut.Index,
                            String.Concat(i.OutTx.Hash.Select(b => b.ToString("x2"))));
                    }),
                    tx.TxOuts.OrderBy(o => o.Index).Select(o => new TxOutput(o.Address,
                        (long)o.Value,
                        o.Index,
                        hash
                    )),
                    new Block(String.Concat(tx.Block.Hash.Select(b => b.ToString("x2")))),
                    (long)tx.Fee,
                    (long)tx.OutSum,
                    tx.BlockIndex,
                    tx.Deposit,
                    (long)(tx.InvalidHereafter ?? 0),
                    tx.Size);
            }).ToDictionary(o => o.Hash);
        }
    }
}

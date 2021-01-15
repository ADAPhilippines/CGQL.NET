using System.Collections.Generic;
using System.Linq;
using CGQL.NET.Models;
using CGQL.NET.Server.Data.Entities;

namespace CGQL.NET.Server.GraphQL.DataLoaders
{
    static class TransactionDataLoaderHelpers
    {
        public static IEnumerable<Transaction> BuildTransactionsfromTxes(IEnumerable<Tx> txes)
        {
            return txes.GroupBy(tx => tx.Hash).Select(txGroup =>
            {
                var hash = CGQLHelpers.ByteArrayToHexString(txGroup.Key);
                var tx = txGroup.First();
                var ins = tx.InTxIns.OrderBy(i => i.OutTx.Id).Select(i =>
                {
                    var txOut = i.OutTx.TxOuts.ToList()[i.TxOutIndex];
                    return new TxOutput(txOut.Address,
                        (long)txOut.Value,
                        txOut.Index,
                        CGQLHelpers.ByteArrayToHexString(i.OutTx.Hash));
                });
                var outs = tx.TxOuts.OrderBy(o => o.Index).Select(o => new TxOutput(o.Address,
                    (long)o.Value,
                    o.Index,
                    hash
                ));
                return new Transaction(
                    hash,
                    ins,
                    outs,
                    default!,
                    tx.Fee,
                    tx.OutSum,
                    tx.BlockIndex,
                    tx.Deposit,
                    tx.InvalidHereafter ?? 0m,
                    tx.Size);
            });
        } 
    }
}
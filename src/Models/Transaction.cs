using System.Collections.Generic;

namespace CGQL.NET.Models
{
    public record Transaction(
        string Hash, 
        IEnumerable<TxOutput> Ins,
        IEnumerable<TxOutput> Outs, 
        Block Block,
        decimal Fee,
        decimal Amount,
        int BlockIndex,
        long Deposit,
        decimal Ttl,
        int Size);
}
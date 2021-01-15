using System;
using System.Collections.Generic;

namespace CGQL.NET.Models
{
    public record Block(
        string Hash, 
        int BlockNo,
        int EpochNo,
        int SlotNo,
        Block PreviousBlock,
        Block NextBlock,
        int Size,
        DateTime Time,
        string MerkelRoot,
        IEnumerable<Transaction> Transactions
    );
}
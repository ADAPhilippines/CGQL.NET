using System.Collections.Generic;

namespace CGQL.NET.Models
{
    public record Address(string Hash, int TxCount, long Balance, IEnumerable<Transaction> Transactions);
}
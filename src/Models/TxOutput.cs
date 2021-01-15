namespace CGQL.NET.Models
{
    public record TxOutput(string Address, long Amount, int Index, string TxHash);
}
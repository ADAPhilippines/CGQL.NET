namespace CGQL.NET.Models
{
    public record TransactionMetadata(
        decimal Key,
        string Json,
        Transaction Transaction
    );
}
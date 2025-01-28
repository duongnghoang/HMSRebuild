namespace Domain.Entities.Common.Enumeration.Definition;

public enum TransactionType
{
    Income,
    Expense
}
public class TransactionTypeCode
{
    public const string Income = "Income";
    public const string Expense = "Expense";
}
public static class TransactionTypeConversion
{
    public static string TransactionTypeToString(this TransactionType transactionType)
    {
        return transactionType switch
        {
            TransactionType.Income => TransactionTypeCode.Income,
            TransactionType.Expense => TransactionTypeCode.Expense,
            _ => throw new NotImplementedException("Invalid Tracaction Type enum")
        };
    }

    public static TransactionType BookingStatusToEnum(string transactionType)
    {
        return transactionType switch
        {
            TransactionTypeCode.Income => TransactionType.Income,
            TransactionTypeCode.Expense => TransactionType.Expense,
            _ => throw new ArgumentException("Invalid Reservation Status string", nameof(transactionType))
        };
    }
}
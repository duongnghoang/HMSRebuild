namespace Domain.Entities.Common.Enumeration.Definition;

public enum PaymentStatus
{
    Unpaid,
    Paid,
}

public class PaymentStatusTranslation
{
    public const string Unpaid = "Chưa thanh toán";
    public const string Paid = "Đã thanh toán";
}

public static class PaymentStatusConversion
{
    // Converts PaymentStatus enum to its string translation
    public static string PaymentStatusToString(this PaymentStatus status)
    {
        return status switch
        {
            PaymentStatus.Unpaid => PaymentStatusTranslation.Unpaid,
            PaymentStatus.Paid => PaymentStatusTranslation.Paid,
            _ => throw new ArgumentException("Invalid Payment Status", nameof(status))
        };
    }

    // Converts string translation back to the PaymentStatus enum
    public static PaymentStatus PaymentStatusToEnum(string paymentStatusString)
    {
        return paymentStatusString switch
        {
            PaymentStatusTranslation.Unpaid => PaymentStatus.Unpaid,
            PaymentStatusTranslation.Paid => PaymentStatus.Paid,
            _ => throw new ArgumentException("Invalid Payment Status string", nameof(paymentStatusString))
        };
    }
}

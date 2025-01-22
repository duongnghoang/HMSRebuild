namespace Domain.DomainCommon.Enumeration.Definition;

public enum PaymentMethod
{
    /// <summary>
    /// tiền mặt
    /// </summary>
    Cash,

    /// <summary>
    /// thẻ tín dụng
    /// </summary>
    CreditCard,

    /// <summary>
    /// chuyển khoản ngân hàng
    /// </summary>
    BankTransfer
}

public class PaymentMethodTranslation
{
    public const string Cash = "Cash";
    public const string CreditCard = "Credit Card";
    public const string BankTransfer = "Bank Transfer";
}

public static class PaymentMethodConversion
{
    // Converts PaymentMethod enum to its string translation
    public static string PaymentMethodToString(this PaymentMethod method)
    {
        return method switch
        {
            PaymentMethod.Cash => PaymentMethodTranslation.Cash,
            PaymentMethod.CreditCard => PaymentMethodTranslation.CreditCard,
            PaymentMethod.BankTransfer => PaymentMethodTranslation.BankTransfer,
            _ => throw new ArgumentException("Invalid Payment Method", nameof(method))
        };
    }

    // Converts string translation back to the PaymentMethod enum
    public static PaymentMethod PaymentMethodToEnum(string paymentMethodString)
    {
        return paymentMethodString switch
        {
            PaymentMethodTranslation.Cash => PaymentMethod.Cash,
            PaymentMethodTranslation.CreditCard => PaymentMethod.CreditCard,
            PaymentMethodTranslation.BankTransfer => PaymentMethod.BankTransfer,
            _ => throw new ArgumentException("Invalid Payment Method string", nameof(paymentMethodString))
        };
    }
}

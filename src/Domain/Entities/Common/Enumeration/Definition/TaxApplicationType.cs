namespace Domain.DomainCommon.Enumeration.Definition;

public enum TaxApplicationType
{
    BeforeRoomDiscount,
    AfterRoomDiscount,
    /// <summary>
    /// BelongToService để chỉ rõ có những tax sẽ chỉ thuộc vào service đấy
    /// </summary>
    BelongToService,
    BeforeServiceDiscount,
    AfterServiceDiscount,
    OnInvoiceTotal
}
public class TaxApplicationTypeTranslation
{
    public const string BeforeRoomDiscount = "Thuế/Phí Phòng trước giảm giá";
    public const string AfterRoomDiscount = "Thuế/Phí Phòng sau giảm giá";
    public const string BelongToService = "Thuế/Phí Thuộc về dịch vụ";
    public const string BeforeServiceDiscount = "Thuế/Phí Dịch vụ trước giảm giá";
    public const string AfterServiceDiscount = "Thuế/Phí Dịch vụ sau giảm giá";
    public const string OnInvoiceTotal = "Thuế/Phí Hóa đơn tổng";
}
public static class TaxApplicationTypeConversion
{
    // Converts TaxApplicationType enum to its string translation
    public static string TaxApplicationTypeToString(this TaxApplicationType method)
    {
        return method switch
        {
            TaxApplicationType.BeforeRoomDiscount => TaxApplicationTypeTranslation.BeforeRoomDiscount,
            TaxApplicationType.AfterRoomDiscount => TaxApplicationTypeTranslation.AfterRoomDiscount,
            TaxApplicationType.BelongToService => TaxApplicationTypeTranslation.BelongToService,
            TaxApplicationType.BeforeServiceDiscount => TaxApplicationTypeTranslation.BeforeServiceDiscount,
            TaxApplicationType.AfterServiceDiscount => TaxApplicationTypeTranslation.AfterServiceDiscount,
            TaxApplicationType.OnInvoiceTotal => TaxApplicationTypeTranslation.OnInvoiceTotal,
            _ => throw new ArgumentException("Invalid Tax Application Type", nameof(method))
        };
    }

    // Converts string translation back to the TaxApplicationType enum
    public static TaxApplicationType TaxApplicationTypeToEnum(string taxApplicationTypeString)
    {
        return taxApplicationTypeString switch
        {
            TaxApplicationTypeTranslation.BeforeRoomDiscount => TaxApplicationType.BeforeRoomDiscount,
            TaxApplicationTypeTranslation.AfterRoomDiscount => TaxApplicationType.AfterRoomDiscount,
            TaxApplicationTypeTranslation.BelongToService => TaxApplicationType.BelongToService,
            TaxApplicationTypeTranslation.BeforeServiceDiscount => TaxApplicationType.BeforeServiceDiscount,
            TaxApplicationTypeTranslation.AfterServiceDiscount => TaxApplicationType.AfterServiceDiscount,
            TaxApplicationTypeTranslation.OnInvoiceTotal => TaxApplicationType.OnInvoiceTotal,
            _ => throw new ArgumentException("Invalid Tax Application Type String", nameof(taxApplicationTypeString))
        };
    }
}
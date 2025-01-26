namespace Domain.Entities.Common.Enumeration;

public static class EnumConfiguration
{
    public static string ConvertToString(this Enum eff)
        => Enum.GetName(eff.GetType(), eff);

    public static EnumType ConverToEnum<EnumType>(this string enumValue)
        => (EnumType)Enum.Parse(typeof(EnumType), enumValue);
}

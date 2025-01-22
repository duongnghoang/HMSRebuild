namespace Domain.DomainCommon.Enumeration;

public static class EnumConfiguration
{
    public static String ConvertToString(this Enum eff)
        => Enum.GetName(eff.GetType(), eff);

    public static EnumType ConverToEnum<EnumType>(this String enumValue)
        => (EnumType)Enum.Parse(typeof(EnumType), enumValue);
}

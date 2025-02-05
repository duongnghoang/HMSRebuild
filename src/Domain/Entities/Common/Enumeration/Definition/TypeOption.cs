namespace Domain.Entities.Common.Enumeration.Definition
{
    public enum TypeOption
    {
        Percentage,
        Amount,
    }

    public class TypeOptionTranslation
    {
        public const string Percentage = "Phần trăm";
        public const string Amount = "Lượng tiền";
    }

    public static class TypeOptionConversion
    {
        public static string TypeOptionToString(this TypeOption status)
        {
            return status switch
            {
                TypeOption.Percentage => TypeOptionTranslation.Percentage,
                TypeOption.Amount => TypeOptionTranslation.Amount,
                _ => throw new ArgumentException("Invalid Type Option", nameof(status))
            };
        }

        // Converts string translation back to the TypeOption enum
        public static TypeOption TypeOptionToEnum(string typeOptionString)
        {
            return typeOptionString switch
            {
                TypeOptionTranslation.Percentage => TypeOption.Percentage,
                TypeOptionTranslation.Amount => TypeOption.Amount,
                _ => throw new ArgumentException("Invalid Type Option string", nameof(typeOptionString))
            };
        }
    }
}

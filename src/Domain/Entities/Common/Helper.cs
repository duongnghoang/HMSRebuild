namespace Domain.Entities.Common;

public class Helper
{
    public static string DefaultStringPrimaryKey => Guid.NewGuid().ToString();
}

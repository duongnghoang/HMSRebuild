namespace Domain.Entities.Common.Enumeration.Definition;
public enum LogType
{
    None,
    Repair,
    ChangeCurrency
}
public class LogTypeCode
{
    /// <summary>
    /// None tức là chỉ log thao tác, bất cứ các thao tác nào cx đc
    /// </summary>
    public const string None = "None";
    /// <summary>
    /// Dành cho log sửa chữa thiết bị
    /// </summary>
    public const string Repair = "Repair";
    /// <summary>
    /// Dành cho thay đổi tiền tệ
    /// </summary>
    public const string ChangeCurrency = "ChangeCurrency";
}
public static class LogTypeConversion
{
    public static string LogTypeToString(this LogType logType)
    {
        return logType switch
        {
           LogType.None => LogTypeCode.None,
           LogType.Repair => LogTypeCode.Repair,
           LogType.ChangeCurrency => LogTypeCode.ChangeCurrency,
            _ => throw new NotImplementedException("Invalid Reservation Status enum")
        };
    }

    public static LogType BookingStatusToEnum(string logType)
    {
        return logType switch
        {
            LogTypeCode.None => LogType.None,
            LogTypeCode.Repair => LogType.Repair,
            LogTypeCode.ChangeCurrency => LogType.ChangeCurrency,
            _ => throw new ArgumentException("Invalid Reservation Status string", nameof(logType))
        };
    }
}
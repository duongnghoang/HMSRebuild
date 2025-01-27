namespace Domain.Entities.Common.Enumeration.Definition;
public enum LogType
{
    None,
    Repair,
    ChangeCurrency
}
public class LogTypeCode
{

}
public static class LogTypeConversion
{
    public static string LogTypeToString(this LogType logType)
    {
        return logType switch
        {
           
        };
    }

    public static LogType BookingStatusToEnum(string logType)
    {
        return logType switch
        {
           
        };
    }
}
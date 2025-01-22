namespace Domain.DomainCommon.Enumeration.Definition;

public enum BookingStatus
{
    Booked,
    NotArrivedYet,
    CheckIn,
    NotGoneYet,
    Gone,
    Cancelled
}

internal class BookingStatusCode
{
    /// <summary>
    /// Phòng đã được đặt trước
    /// </summary>
    public const string Booked = "BOOKED";

    /// <summary>
    /// Phòng chờ khách đến
    /// đến giờ checkin nhưng khách chưa tới
    /// </summary>
    public const string NotArrivedYet = "NOT_ARRIVED_YET";

    /// <summary>
    /// Phòng có khách
    /// </summary>
    public const string CheckIn = "CHECK_IN";

    /// <summary>
    /// Quá hạn trả phòng
    /// đến giờ checkout nhưng khách chưa đi
    /// </summary>
    public const string NotGoneYet = "NOT_GONE_YET";

    /// <summary>
    /// khách đã trả phòng
    /// </summary>
    public const string Gone = "GONE";

    /// <summary>
    /// khách hủy book phòng
    /// </summary>
    public const string Cancelled = "CANCELLED";
}

public static class BookingStatusConversion
{
    public static string BookingStatusToString(this BookingStatus bookingStatus)
    {
        return bookingStatus switch
        {
            BookingStatus.Booked => BookingStatusCode.Booked,
            BookingStatus.NotArrivedYet => BookingStatusCode.NotArrivedYet,
            BookingStatus.CheckIn => BookingStatusCode.CheckIn,
            BookingStatus.NotGoneYet => BookingStatusCode.NotGoneYet,
            BookingStatus.Gone => BookingStatusCode.Gone,
            BookingStatus.Cancelled => BookingStatusCode.Cancelled,
            _ => throw new NotImplementedException("Invalid Reservation Status enum")
        };
    }

    public static BookingStatus BookingStatusToEnum(string bookingStatus)
    {
        return bookingStatus switch
        {
            BookingStatusCode.Booked => BookingStatus.Booked,
            BookingStatusCode.NotArrivedYet => BookingStatus.NotArrivedYet,
            BookingStatusCode.CheckIn => BookingStatus.CheckIn,
            BookingStatusCode.NotGoneYet => BookingStatus.NotGoneYet,
            BookingStatusCode.Gone => BookingStatus.Gone,
            BookingStatusCode.Cancelled => BookingStatus.Cancelled,
            _ => throw new ArgumentException("Invalid Reservation Status string", nameof(bookingStatus))
        };
    }
}
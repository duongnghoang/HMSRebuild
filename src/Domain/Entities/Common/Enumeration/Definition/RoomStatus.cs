namespace Domain.DomainCommon.Enumeration.Definition;

public enum RoomStatus
{
    Available,
    Booked,
    NotArrivedYet,
    CheckIn,
    NotGoneYet,
    Repairing,
    Dirty,
}

internal class RoomStatusTranslation
{
    /// <summary>
    /// Phòng trống
    /// </summary>
    public const string Available = "AVAILABLE";

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

    //public const string Dirty = "DIRTY";

    public const string Repairing = "REPAIRING";
}

public static class RoomStatusConversion
{
    public static string RoomStatusToString(this RoomStatus roomStatusEnum)
    {
        return roomStatusEnum switch
        {
            RoomStatus.Available => RoomStatusTranslation.Available,
            RoomStatus.Booked => RoomStatusTranslation.Booked,
            RoomStatus.NotArrivedYet => RoomStatusTranslation.NotArrivedYet,
            RoomStatus.CheckIn => RoomStatusTranslation.CheckIn,
            RoomStatus.NotGoneYet => RoomStatusTranslation.NotGoneYet,
            RoomStatus.Repairing => RoomStatusTranslation.Repairing,
            //RoomStatus.Dirty => RoomStatusTranslation.Dirty,
            _ => throw new NotImplementedException("Invalid Room Status")
        };
    }

    public static RoomStatus RoomStatusToEnum(string roomOcupancyStatusString)
    {
        return roomOcupancyStatusString switch
        {
            RoomStatusTranslation.Available => RoomStatus.Available,
            RoomStatusTranslation.Booked => RoomStatus.Booked,
            RoomStatusTranslation.NotArrivedYet => RoomStatus.NotArrivedYet,
            RoomStatusTranslation.CheckIn => RoomStatus.CheckIn,
            RoomStatusTranslation.NotGoneYet => RoomStatus.NotGoneYet,
            RoomStatusTranslation.Repairing => RoomStatus.Repairing,
            //RoomStatusTranslation.Dirty => RoomStatus.Dirty,
            _ => throw new ArgumentException("Invalid Room Status string", nameof(roomOcupancyStatusString))
        };
    }
}
namespace Domain.Entities.Common.Enumeration.Definition;

public enum ReservationRoomStatus
{
    UnAssignedRoom,
    AssignedRoom,
    CheckedIn,
    CheckedOut
}

public class ReservationRoomStatusTranslation
{
    /// <summary>
    /// Booking đã đặt nhưng chưa gán phòng cho khách
    /// </summary>
    public const string UnAssignedRoom = "Chưa gán phòng";
    /// <summary>
    /// Booking đã gán phòng nhưng khách chưa tới check in
    /// đến giờ checkin nhưng khách chưa tới
    /// </summary>
    public const string AssignedRoom = "Đã gán phòng";

    /// <summary>
    /// Phòng có khách
    /// </summary>
    public const string CheckedIn = "Đã check in";

    /// <summary>
    /// Quá hạn trả phòng
    /// đến giờ checkout nhưng khách chưa đi
    /// </summary>
    public const string CheckedOut = "Đã check out";
}

public static class ReservationRoomStatusConversion
{
    public static string ReservationRoomStatusToString(this ReservationRoomStatus roomOcupancyStatusEnum)
    {
        return roomOcupancyStatusEnum switch
        {
            ReservationRoomStatus.UnAssignedRoom => ReservationRoomStatusTranslation.UnAssignedRoom,
            ReservationRoomStatus.AssignedRoom => ReservationRoomStatusTranslation.AssignedRoom,
            ReservationRoomStatus.CheckedIn => ReservationRoomStatusTranslation.CheckedIn,
            ReservationRoomStatus.CheckedOut => ReservationRoomStatusTranslation.CheckedOut,
            _ => throw new NotImplementedException("Invalid ReservationRoom Status")
        };
    }

    public static ReservationRoomStatus ReservationRoomStatusToEnum(string roomOcupancyStatusString)
    {
        return roomOcupancyStatusString switch
        {
            ReservationRoomStatusTranslation.UnAssignedRoom => ReservationRoomStatus.UnAssignedRoom,
            ReservationRoomStatusTranslation.AssignedRoom => ReservationRoomStatus.AssignedRoom,
            ReservationRoomStatusTranslation.CheckedIn => ReservationRoomStatus.CheckedIn,
            ReservationRoomStatusTranslation.CheckedOut => ReservationRoomStatus.CheckedOut,
            _ => throw new ArgumentException("Invalid ReservationRoom Status string", nameof(roomOcupancyStatusString))
        };
    }
}
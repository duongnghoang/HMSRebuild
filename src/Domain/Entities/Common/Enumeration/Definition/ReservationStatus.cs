namespace Domain.Entities.Common.Enumeration.Definition;

public enum ReservationStatus
{
    /// <summary>
    /// The reservation has been made, but it hasn't been confirmed yet.
    /// This may occur when the hotel is waiting for a deposit or final confirmation from the guest.
    /// </summary>
    Pending,

    /// <summary>
    /// The reservation has been officially confirmed by the hotel, and a room has been secured for the guest.
    /// This is typically the status once the booking has been finalized, with all the necessary information provided (guest details, payment, etc.).
    /// </summary>
    Confirmed,

    /// <summary>
    /// The reservation has been cancelled either by the guest or by the hotel.
    /// Cancellations can happen for various reasons, such as a no-show, the guest's change of plans, or non-payment of a deposit.
    /// </summary>
    Cancelled,

    /// <summary>
    /// The guest did not arrive on the check-in date, and the reservation was not cancelled in time.
    /// This status is typically set after a certain period of time has passed on the expected check-in date.
    /// </summary>
    NoShow,

    /// <summary>
    /// The reservation is on a waiting list, meaning the room is not yet available, but the guest will be given priority if space becomes available.
    /// </summary>
    WaitingList
}

public class ReservationStatusTranslation
{
    public const string Pending = "Đang chờ xử lý";
    public const string Confirmed = "Đã xác nhận";
    public const string Cancelled = "Đã hủy";
    public const string NoShow = "Không đến";
    public const string WaitingList = "Danh sách chờ";
}

public static class ReservationStatusConversion
{
    // Converts ReservationStatus enum to its string translation
    public static string ReservationStatusToString(this ReservationStatus status)
    {
        return status switch
        {
            ReservationStatus.Pending => ReservationStatusTranslation.Pending,
            ReservationStatus.Confirmed => ReservationStatusTranslation.Confirmed,
            ReservationStatus.Cancelled => ReservationStatusTranslation.Cancelled,
            ReservationStatus.NoShow => ReservationStatusTranslation.NoShow,
            ReservationStatus.WaitingList => ReservationStatusTranslation.WaitingList,
            _ => throw new ArgumentException("Invalid Reservation Status", nameof(status))
        };
    }

    // Converts string translation back to the ReservationStatus enum
    public static ReservationStatus ReservationStatusToEnum(string reservationStatusString)
    {
        return reservationStatusString switch
        {
            ReservationStatusTranslation.Pending => ReservationStatus.Pending,
            ReservationStatusTranslation.Confirmed => ReservationStatus.Confirmed,
            ReservationStatusTranslation.Cancelled => ReservationStatus.Cancelled,
            ReservationStatusTranslation.NoShow => ReservationStatus.NoShow,
            ReservationStatusTranslation.WaitingList => ReservationStatus.WaitingList,
            _ => throw new ArgumentException("Invalid Reservation Status string", nameof(reservationStatusString))
        };
    }
}

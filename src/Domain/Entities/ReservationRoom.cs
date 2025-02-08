using Domain.DevelopingEntities.RoomTypeFees;
using Domain.Entities.Common;
using Domain.Entities.Common.Enumeration.Definition;
using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class ReservationRoom : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public int ReservationId { get; set; }
    public int? RoomId { get; set; }
    /// <summary>
    /// Guest who really stay at the room
    /// </summary>
    public string? GuestId { get; set; }

    /// <summary>
    /// quan hệ 1 1 vs chính sách giá
    /// </summary>
    public int FeePolicyId { get; set; }
    public int? NumberOfAdult { get; set; }
    public int? NumberOfChild { get; set; }
    public decimal? PunishFeeForOverAdult { get; set; }
    public decimal? PunishFeeForOverChild { get; set; }

    public BookingStatus BookingStatus { get; set; } = BookingStatus.Booked;
    /// <summary>
    /// Khi hủy cần lưu lý do
    /// </summary>
    public string? ReasonForCancellation { get; set; }
    /// <summary>
    /// Lý do đổi phòng
    /// </summary>
    public string? ReasonForMoveRoom { get; set; }
    /// <summary>
    ///
    /// </summary>
    public string? ReasonForUndoCheckOut { get; set; }
    /// <summary>
    /// cho Checkout trong quá khứ
    /// ví dụ như đã ở quá ngày booking, thường thì phải gia hạn, nhưng có thể chọn chỉ thanh toán tới ngày booking mà không phát sinh thêm
    /// </summary>
    public bool? CanCheckOutInPast { get; set; }
    /// <summary>
    /// Thời gian khách thay đổi lịch đặt checkin so với reservation (cho đoàn)
    /// </summary>
    public DateTime? CheckInBooking { get; set; }

    /// <summary>
    /// Thời gian khách thay đổi lịch đặt checkout so với reservation (cho đoàn)
    /// </summary>
    public DateTime? CheckOutBooking { get; set; }

    /// <summary>
    /// Thời gian khách thực sự bắt đầu vào ở
    /// </summary>
    public DateTime? CheckInDate { get; set; }

    /// <summary>
    /// Thời gian khách thực sự trả phòng (để rời đi/chuyển sang phòng khác/...)
    /// </summary>
    public DateTime? CheckOutDate { get; set; }

    [ForeignKey(nameof(GuestId))]
    public virtual Guest? Guest { get; set; }

    [ForeignKey(nameof(ReservationId))]
    public virtual Reservation? Reservation { get; set; }

    [ForeignKey(nameof(RoomId))]
    public virtual Room? Room { get; set; }

    [ForeignKey(nameof(FeePolicyId))]
    public virtual FeePolicy? FeePolicy { get; set; }

}

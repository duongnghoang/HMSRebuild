using Domain.DevelopingEntities.BookingType;
using Domain.Entities.Common;
using Domain.Entities.Common.Enumeration.Definition;
using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities;

public class Reservation : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    /// <summary>
    /// Khách đại diện booking (có thể đặt cho cả đoàn/gia đình/bản thân)
    /// </summary>
    public string GuestId { get; set; }
    /// <summary>
    /// Booking agency, nullable
    /// </summary>
    public int? CompanyId { get; set; }
    public int? MarketId { get; set; }
    public int? SourceId { get; set; }

    /// <summary>
    /// Mã hiển thị đoàn, được tạo khi đặt từ 2 phòng trở lên, có thể NULL
    /// </summary>
    public string? GroupCode { get; set; }
    /// <summary>
    /// hóa đơn tổng
    /// tạm thời để nullable để tránh lỗi dữ liệu trong db
    /// </summary>
    public int? InvoiceId { get; set; }
    /// <summary>
    /// Scheduled check-in date
    /// </summary>
    public DateTime CheckInDate { get; set; }

    /// <summary>
    /// Scheduled check-out date
    /// </summary>
    public DateTime CheckOutDate { get; set; }
    /// <summary>
    /// Any special requests or notes (e.g., wheelchair access, extra bed)
    /// </summary>
    public string? Note { get; set; }
    /// <summary>
    /// Lưu nhân viên tạo
    /// </summary>
    public string? CreatedBy { get; set; }

    /// <summary>
    /// Payment status (e.g., Paid, Unpaid)
    /// </summary>
    public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Paid;
    [ForeignKey(nameof(GuestId))]
    public virtual Guest? Guest { get; set; }

    [ForeignKey(nameof(InvoiceId))]
    public virtual Invoice? Invoice { get; set; }

    [ForeignKey(nameof(CompanyId))]
    public virtual Company? Company { get; set; }

    [ForeignKey(nameof(MarketId))]
    public virtual Market? Market { get; set; }

    [ForeignKey(nameof(SourceId))]
    public virtual Source? Source { get; set; }

    [ForeignKey(nameof(CreatedBy))]
    public virtual Staff? Staff { get; set; }

}

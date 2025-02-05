using Domain.Entities.Common;
using Domain.Entities.Common.Enumeration.Definition;
using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities;

public class Receipt : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public string StaffId { get; set; }
    public int PaymentMethodId { get; set; }
    public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Unpaid;
    public string GuestName { get; set; }
    /// <summary>
    /// Nếu chuyển Receipt này vào phòng thì sẽ để ReservationRoomId không null
    /// </summary>
    public int? ReservationRoomId {  get; set; }

    [ForeignKey(nameof(StaffId))]
    public virtual Staff? ReceiptCreatedStaff { get; set; }

    [ForeignKey(nameof(PaymentMethodId))]
    public virtual PaymentMethod? PaymentMethod { get; set; }
    [ForeignKey(nameof(ReservationRoomId))]
    public virtual ReservationRoom? ReservationRoom { get; set; }

}

using Domain.DomainCommon.Interface;
using Domain.Entities.Common;
using Domain.Entities.Common.Enumeration.Definition;
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

    [ForeignKey(nameof(StaffId))]
    public virtual Staff? ReceiptCreatedStaff { get; set; }

    [ForeignKey(nameof(PaymentMethodId))]
    public virtual PaymentMethod? PaymentMethod { get; set; }

}

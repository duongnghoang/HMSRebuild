using Domain.Entities.Common;
using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities;

public class ServiceUsage : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public int Quantity { get; set; }
    public int ReceiptId { get; set; }
    public int ServiceId { get; set; }
    public decimal TotalPrice { get; set; }

    [ForeignKey(nameof(ServiceId))]
    public virtual Service? Service { get; set; }

    [ForeignKey(nameof(ReceiptId))]
    public virtual Receipt? Receipt { get; set; }
}

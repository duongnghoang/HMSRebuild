using Domain.Entities.Common;
using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities;

public class Invoice : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public string? GuestId { get; set; }
    public int? ReservationId { get; set; }
    public decimal? TotalPrice { get; set; }
    public decimal? TotalPaid { get; set; }
    public decimal? RemainPrice { get; set; }
    [ForeignKey(nameof(GuestId))]
    public virtual Guest? Guest { get; set; }
    [ForeignKey(nameof(ReservationId))]
    public virtual Reservation? Reservation { get; set; }
}

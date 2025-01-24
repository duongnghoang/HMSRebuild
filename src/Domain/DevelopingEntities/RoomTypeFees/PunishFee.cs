using Domain.DomainCommon.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities.RoomTypeFees;

/// <summary>
/// Phí phạt khi checkin/checkout sớm/muộn
/// </summary>
public class PunishFee : IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public int? DayFeeId { get; set; }
    public int? NightFeeId { get; set; }

    public string NumOfHour { get; set; }
    public decimal Fee { get; set; }
    public bool IsCheckInEarlyOrCheckOutLate { get; set; }


    [ForeignKey(nameof(DayFeeId))]
    public virtual DayFee? DayFee { get; set; }

    [ForeignKey(nameof(NightFeeId))]
    public virtual NightFee? NightFee { get; set; }
}

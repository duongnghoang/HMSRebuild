using Domain.DomainCommon.Interface;
using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities.RoomTypeFees;

public class FeePolicy : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int RoomTypeId { get; set; }
    public bool IsActive { get; set; }
    public virtual DayFee? DayFee { get; set; }
    public virtual HourFee? HourFee { get; set; }
    public virtual MonthFee? MonthFee { get; set; }
    public virtual NightFee? NightFee { get; set; }
    public virtual WeekFee? WeekFee { get; set; }

    [ForeignKey(nameof(RoomTypeId))]
    public virtual RoomType? RoomType { get; set; }
}

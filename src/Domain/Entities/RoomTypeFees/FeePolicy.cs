using Domain.Abstractions.BaseObjects;
using Domain.DevelopingEntities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.RoomTypeFees
{
    public class FeePolicy : BaseEntity, IAuditableEntity, ISoftDelete
    {
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
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
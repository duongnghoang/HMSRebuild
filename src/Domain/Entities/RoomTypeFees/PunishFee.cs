using Domain.Abstractions.BaseObjects;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.RoomTypeFees
{
    /// <summary>
    /// Phí phạt khi checkin/checkout sớm/muộn
    /// </summary>
    public class PunishFee : BaseEntity
    {
        public Guid? DayFeeId { get; set; }
        public Guid? NightFeeId { get; set; }

        public TimeSpan NumOfHour { get; set; }
        public decimal Fee { get; set; }
        public bool IsCheckInEarlyOrCheckOutLate { get; set; }

        [ForeignKey(nameof(DayFeeId))]
        public virtual DayFee? DayFee { get; set; }

        [ForeignKey(nameof(NightFeeId))]
        public virtual NightFee? NightFee { get; set; }
    }
}
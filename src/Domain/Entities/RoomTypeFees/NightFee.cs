using Domain.Abstractions.BaseObjects;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.RoomTypeFees
{
    public class NightFee : BaseEntity
    {
        public TimeSpan CheckIn { get; set; } = new TimeSpan(21, 0, 0);
        public TimeSpan CheckOut { get; set; } = new TimeSpan(12, 0, 0);
        public decimal Fee { get; set; } = 0;
        public Guid FeePolicyId { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey(nameof(FeePolicyId))]
        public virtual FeePolicy? FeePolicy { get; set; }

        public virtual ICollection<PunishFee> PunishFees { get; set; }
    }
}
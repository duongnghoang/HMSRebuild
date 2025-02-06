using Domain.Abstractions.BaseObjects;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.RoomTypeFees
{
    public class WeekFee : BaseEntity
    {
        public decimal Fee { get; set; } = 0;
        public int FeePolicyId { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey(nameof(FeePolicyId))]
        public virtual FeePolicy? FeePolicy { get; set; }
    }
}
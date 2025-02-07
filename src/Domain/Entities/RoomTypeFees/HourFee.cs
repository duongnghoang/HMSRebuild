using Domain.Abstractions.BaseObjects;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.RoomTypeFees
{
    public class HourFee : BaseEntity
    {
        public Guid FeePolicyId { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<HourFeePrice>? HourFeePrices { get; set; } = new List<HourFeePrice>();

        [ForeignKey(nameof(FeePolicyId))]
        public virtual FeePolicy? FeePolicy { get; set; }
    }
}
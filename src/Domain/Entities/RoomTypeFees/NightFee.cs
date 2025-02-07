using Domain.Abstractions.BaseObjects;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.RoomTypeFees
{
    public class NightFee : BaseEntity
    {
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public decimal Fee { get; set; } = 0;
        public Guid FeePolicyId { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey(nameof(FeePolicyId))]
        public virtual FeePolicy? FeePolicy { get; set; }

        public virtual ICollection<PunishFee> PunishFees { get; set; }
    }
}
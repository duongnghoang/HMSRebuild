using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities.RoomTypeFees;

public class NightFee : IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public TimeSpan CheckIn { get; set; }
    public TimeSpan CheckOut { get; set; }
    public decimal Fee { get; set; } = 0;
    public int FeePolicyId { get; set; }
    public bool IsActive { get; set; }

    [ForeignKey(nameof(FeePolicyId))]
    public virtual FeePolicy? FeePolicy { get; set; }

    public virtual ICollection<PunishFee> PunishFees { get; set; }
}

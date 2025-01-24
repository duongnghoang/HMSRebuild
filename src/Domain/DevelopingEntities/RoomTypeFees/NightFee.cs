using Domain.DomainCommon.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities.RoomTypeFees;

public class NightFee : IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public string CheckIn { get; set; }
    public string CheckOut { get; set; }
    public decimal Fee { get; set; } = 0;
    public int FeePolicyId { get; set; }
    public bool IsInUsed { get; set; } = false;

    [ForeignKey(nameof(FeePolicyId))]
    public virtual FeePolicy? FeePolicy { get; set; }

    public virtual ICollection<PunishFee> PunishFees { get; set; }
}

using Domain.DomainCommon.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities.RoomTypeFees;

public class WeekFee : IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public decimal Fee { get; set; } = 0;
    public int FeePolicyId { get; set; }

    public bool IsActive { get; set; }

    [ForeignKey(nameof(FeePolicyId))]
    public virtual FeePolicy? FeePolicy { get; set; }
}

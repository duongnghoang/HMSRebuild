using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities.RoomTypeFees;

public class MonthFee : IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public decimal Fee { get; set; } = 0;
    public bool WhenToCalculate { get; set; } = false;
    public int FeePolicyId { get; set; }
    public bool IsActive { get; set; }

    [ForeignKey(nameof(FeePolicyId))]
    public virtual FeePolicy? FeePolicy { get; set; }
}

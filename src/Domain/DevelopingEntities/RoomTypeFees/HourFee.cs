using Domain.DomainCommon.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities.RoomTypeFees;

public class HourFee : IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public int FeePolicyId { get; set; }
    public bool IsActive { get; set; }
    public virtual ICollection<HourFeePrice>? HourFeePrices { get; set; } = new List<HourFeePrice>();

    [ForeignKey(nameof(FeePolicyId))]
    public virtual FeePolicy? FeePolicy { get; set; }


}

using Domain.DomainCommon.Interface;
using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities;

public class TransactionCategory : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public int Name { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsActive { get; set; }
    public int TransactionGroupId { get; set; }
    [ForeignKey(nameof(TransactionGroupId))]
    public virtual TransactionGroup? TransactionGroup { get; set; }
}

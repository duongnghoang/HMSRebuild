using Domain.Entities.Common;
using Domain.Entities.Common.Enumeration.Definition;
using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;

namespace Domain.DevelopingEntities;

public class TransactionGroup : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public TransactionType TransactionType { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
}

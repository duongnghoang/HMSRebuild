using Domain.DomainCommon.Interface;
using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace Domain.DevelopingEntities;

public class Transaction : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    
}

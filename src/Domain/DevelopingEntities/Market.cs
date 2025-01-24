using Domain.DomainCommon.Interface;
using System.ComponentModel.DataAnnotations;

namespace Domain.DevelopingEntities;

public class Market : IResponse<int>
{
    [Key]
    public int Id { get; set; }
    
}

using Domain.Entities.Common;
using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;

namespace Domain.DevelopingEntities;

public class Equipment : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Unit { get; set; }
    public string Code { get; set; }
    public bool IsActive { get; set; }
}

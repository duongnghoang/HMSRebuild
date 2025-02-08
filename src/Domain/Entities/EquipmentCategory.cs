using Domain.Entities.Common;
using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class EquipmentCategory : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
}

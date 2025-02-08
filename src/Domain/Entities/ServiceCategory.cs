using Domain.Entities.Common;
using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class ServiceCategory : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
}

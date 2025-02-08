using Domain.Entities.Common;
using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Floor : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public int? BuildingId { get; set; }
    public string Name { get; set; }

    [ForeignKey(nameof(BuildingId))]
    public virtual Building? Building { get; set; }
}

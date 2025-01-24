using Domain.DomainCommon.Interface;
using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities;

public class Floor : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public int? BuildingId { get; set; }
    public string Name { get; set; }

    [ForeignKey(nameof(BuildingId))]
    public Building? Building { get; set; }
}

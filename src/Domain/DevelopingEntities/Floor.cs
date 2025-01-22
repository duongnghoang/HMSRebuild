using Domain.DomainCommon;
using Domain.DomainCommon.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity;

public class Floor : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public int? BuildingId { get; set; }
    public string Name { get; set; }

    [ForeignKey(nameof(BuildingId))]
    public Building? Building { get; set; }
}

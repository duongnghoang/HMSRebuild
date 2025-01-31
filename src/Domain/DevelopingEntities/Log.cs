using Domain.DomainCommon.Interface;
using Domain.Entities.Common;
using Domain.Entities.Common.Enumeration.Definition;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities;

public class Log : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public string? StaffId { get; set; }
    public int? RoomId { get; set; }
    public string? Detail {  get; set; }
    public LogType LogType { get; set; }

    [ForeignKey(nameof(StaffId))]
    public virtual Staff? Staff { get; set; }
    [ForeignKey(nameof(RoomId))]
    public virtual Room? Room { get; set; }
}

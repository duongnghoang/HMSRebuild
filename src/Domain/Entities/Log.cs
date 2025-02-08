using Domain.DevelopingEntities;
using Domain.Entities.Common;
using Domain.Entities.Common.Enumeration.Definition;
using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Log : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public string? StaffId { get; set; }
    public int? RoomId { get; set; }
    public string? Detail { get; set; }
    public LogType LogType { get; set; }

    [ForeignKey(nameof(StaffId))]
    public virtual Staff? Staff { get; set; }
    [ForeignKey(nameof(RoomId))]
    public virtual Room? Room { get; set; }
}

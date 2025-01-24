using Domain.DomainCommon.Interface;
using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities;

public class RoomRepair : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public int RoomId { get; set; }
    public DateTime RepairStartDate { get; set; }
    public DateTime RepairEndDate { get; set; }
    public DateTime? DoneDate { get; set; }
    public string? RepairReason { get; set; }

    public string? CreatedBy { get; set; }
    public string? ModifiedBy { get; set; }
    public string? DoneBy { get; set; }


    [ForeignKey(nameof(RoomId))]
    public virtual Room? Room { get; set; }

    [ForeignKey(nameof(CreatedBy))]
    public virtual Staff? CreatedByStaff { get; set; }

    [ForeignKey(nameof(ModifiedBy))]
    public virtual Staff? ModifiedByStaff { get; set; }

    [ForeignKey(nameof(DoneBy))]
    public virtual Staff? DoneByStaff { get; set; }
}
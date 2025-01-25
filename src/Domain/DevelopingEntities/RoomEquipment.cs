
using Domain.DomainCommon.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities;

public class RoomEquipment : IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public int RoomId { get; set; }
    public int EquipmentId { get; set; }
    public int Quantity { get; set; }
    public string Note { get; set; }

    [ForeignKey(nameof(RoomId))]
    public Room? Room { get; set; }
    [ForeignKey(nameof(EquipmentId))]
    public Equipment? Equipment { get; set; }
}

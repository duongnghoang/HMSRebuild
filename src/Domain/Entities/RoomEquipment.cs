using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class RoomEquipment : IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public int RoomId { get; set; }
    public int EquipmentId { get; set; }
    public int Quantity { get; set; }
    public string Note { get; set; }

    [ForeignKey(nameof(RoomId))]
    public virtual Room? Room { get; set; }
    [ForeignKey(nameof(EquipmentId))]
    public virtual Equipment? Equipment { get; set; }
}

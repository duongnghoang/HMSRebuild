using Domain.Entities.Common;
using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;

namespace Domain.DevelopingEntities;

public class RoomType : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public string? RoomTypeCode { get; set; }
    public string? RoomTypeName { get; set; }
    public int? AdultNumber { get; set; }
    public int? ChildNumber { get; set; }
}

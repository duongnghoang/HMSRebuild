using Domain.DomainCommon.Interface;
using System.ComponentModel.DataAnnotations;

namespace Domain.DevelopingEntities.RoomTypeFees;

public class TimeConfig : IResponse<int>
{
    [Key]
    public int Id { get; set; }
    /// <summary>
    /// Múi giờ dưới dạng "Asia/Ho_Chi_Minh"
    /// </summary>
    public string TimeZone { get; set; } = "UTC";
    public int RoundMinutes { get; set; }
    public required string DayCheckInTime { get; set; }
    public required string DayCheckOutTime { get; set; }
    public required string NightCheckInTime { get; set; }
    public required string NightCheckOutTime { get; set; }

}

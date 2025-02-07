using Domain.Entities.Common.Interface;
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
    public required TimeSpan DayCheckInTime { get; set; }
    public required TimeSpan DayCheckOutTime { get; set; }
    public required TimeSpan NightCheckInTime { get; set; }
    public required TimeSpan NightCheckOutTime { get; set; }

}

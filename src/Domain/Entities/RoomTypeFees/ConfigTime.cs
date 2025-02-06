using Domain.Abstractions.BaseObjects;

namespace Domain.Entities.RoomTypeFees
{
    public class TimeConfig : BaseEntity
    {
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
}
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
        public TimeSpan DayCheckInTime { get; set; }
        public TimeSpan DayCheckOutTime { get; set; }
        public TimeSpan NightCheckInTime { get; set; }
        public TimeSpan NightCheckOutTime { get; set; }
    }
}
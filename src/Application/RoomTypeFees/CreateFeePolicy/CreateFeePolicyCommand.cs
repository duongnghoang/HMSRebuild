using Application.Interfaces;
using Application.RoomTypeFees.RoomFeeDtos;

namespace Application.RoomTypeFees.CreateFeePolicy
{
    public class CreateFeePolicyCommand : ICommand
    {
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public DayFeeDto DayFee { get; set; } = new DayFeeDto();
        public HourFeeDto HourFee { get; set; } = new HourFeeDto();
        public MonthFeeDto MonthFee { get; set; } = new MonthFeeDto();
        public NightFeeDto NightFee { get; set; } = new NightFeeDto();
        public WeekFeeDto WeekFee { get; set; } = new WeekFeeDto();
    }
}
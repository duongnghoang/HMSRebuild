using Application.RoomTypeFees.RoomFeeDtos;
using FluentValidation;

namespace Presentation.Contracts.RoomTypeFees
{
    public class CreateFeePolicyRequest
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public virtual DayFeeDto? DayFee { get; set; }
        public virtual HourFeeDto? HourFee { get; set; }
        public virtual MonthFeeDto? MonthFee { get; set; }
        public virtual NightFeeDto? NightFee { get; set; }
        public virtual WeekFeeDto? WeekFee { get; set; }
    }

    public class CreateFeePolicyRequestValidator : AbstractValidator<CreateFeePolicyRequest>
    {
        public CreateFeePolicyRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
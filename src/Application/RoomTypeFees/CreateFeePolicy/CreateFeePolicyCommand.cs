using Application.Interfaces;

namespace Application.RoomTypeFees.CreateFeePolicy
{
    public class CreateFeePolicyCommand : ICommand
    {
        public string Name { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}
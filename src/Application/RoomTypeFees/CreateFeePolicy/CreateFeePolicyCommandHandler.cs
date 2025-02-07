using Application.Interfaces;
using Domain.Shared;

namespace Application.RoomTypeFees.CreateFeePolicy
{
    public class CreateFeePolicyCommandHandler : ICommandHandler<CreateFeePolicyCommand>
    {
        public Task<Result> Handle(CreateFeePolicyCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
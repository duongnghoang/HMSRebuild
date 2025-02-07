using Application.Interfaces;
using Domain.Abstractions.Repositories;
using Domain.Shared;

namespace Application.RoomTypeFees.CreateFeePolicy
{
    public class CreateFeePolicyCommandHandler : ICommandHandler<CreateFeePolicyCommand>
    {
        private readonly IFeePolicyRepository _feePolicyRepository;

        public CreateFeePolicyCommandHandler(IFeePolicyRepository feePolicyRepository)
        {
            _feePolicyRepository = feePolicyRepository;
        }

        public Task<Result> Handle(CreateFeePolicyCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
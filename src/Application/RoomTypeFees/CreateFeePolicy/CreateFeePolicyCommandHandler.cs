using Application.Interfaces;
using Domain.Abstractions.Repositories;
using Domain.Entities.RoomTypeFees;
using Domain.Shared;
using Mapster;

namespace Application.RoomTypeFees.CreateFeePolicy
{
    public class CreateFeePolicyCommandHandler : ICommandHandler<CreateFeePolicyCommand>
    {
        private readonly IFeePolicyRepository _feePolicyRepository;

        public CreateFeePolicyCommandHandler(IFeePolicyRepository feePolicyRepository)
        {
            _feePolicyRepository = feePolicyRepository;
        }

        public async Task<Result> Handle(CreateFeePolicyCommand request, CancellationToken cancellationToken)
        {
            var feePolicy = request.Adapt<FeePolicy>();
            var isExist = await _feePolicyRepository.IsFeePolicyNameExist(request.Name);
            if (isExist)
            {
                return Result.Failure(FeePolicyErrors.FeePolicyNameExist);
            }

            await _feePolicyRepository.AddAsync(feePolicy);
            return Result.Success();
        }
    }
}
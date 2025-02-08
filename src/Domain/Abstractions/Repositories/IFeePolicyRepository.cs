using Domain.Abstractions.BaseObjects;
using Domain.Entities.RoomTypeFees;

namespace Domain.Abstractions.Repositories
{
    public interface IFeePolicyRepository : IBaseRepository<FeePolicy>
    {
        Task<bool> IsFeePolicyNameExist(string name);

        Task AddAsync(FeePolicy feePolicy);
    }
}
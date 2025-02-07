using Domain.Abstractions.Repositories;
using Domain.Entities.RoomTypeFees;
using Infrastructure.Persistence;
using Infrastructure.Repositories.Base;

namespace Infrastructure.Repositories
{
    internal sealed class FeePolicyRepository : BaseRepository<FeePolicy>, IFeePolicyRepository
    {
        public FeePolicyRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
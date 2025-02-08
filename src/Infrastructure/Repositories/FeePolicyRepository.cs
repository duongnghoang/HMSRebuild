using Domain.Abstractions.Repositories;
using Domain.Entities.RoomTypeFees;
using Infrastructure.Persistence;
using Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    internal sealed class FeePolicyRepository : BaseRepository<FeePolicy>, IFeePolicyRepository
    {
        public FeePolicyRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<bool> IsFeePolicyNameExist(string name)
        {
            bool isExist = await _context.Set<FeePolicy>().AnyAsync(x => x.Name == name);
            if (isExist)
            {
                return true;
            }

            return false;
        }

        public async Task AddAsync(FeePolicy feePolicy)
        {
            await _context.Set<FeePolicy>().AddAsync(feePolicy);
            await _context.SaveChangesAsync();
        }
    }
}
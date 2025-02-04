using Domain.Entities.Users;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services.Authorization
{
    public class PermissionService : IPermissionService
    {
        private readonly ApplicationDbContext _context;

        public PermissionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<HashSet<string>> GetPermissionsAsync(Guid staffId)
        {
            var role = await _context.Set<Staff>()
                .Include(s => s.Role)
                .ThenInclude(rp => rp!.Permissions)
                .Where(x => x.Id == staffId)
                .Select(x => x.Role).FirstOrDefaultAsync();

            return role!.Permissions!
                .Select(x => x.Name).ToHashSet()!;
        }
    }
}
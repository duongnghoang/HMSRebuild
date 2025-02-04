using Domain.Abstractions.Repositories;
using Domain.Entities.Users;
using Infrastructure.Persistence;
using Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    internal sealed class StaffRepository : BaseRepository, IStaffRepository
    {
        public StaffRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Staff?> LoginAsync(string email, string password)
        {
            var staff = await _context.Staffs.FirstOrDefaultAsync(s => s.Email == email);
            return staff;
        }

        public async Task AddAsync(Staff staff)
        {
            await _context.Staffs.AddAsync(staff);
            await _context.SaveChangesAsync();
        }
    }
}
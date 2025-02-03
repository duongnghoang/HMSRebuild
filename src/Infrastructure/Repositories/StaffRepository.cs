using Domain.Abstractions.Repositories;
using Domain.Entities.Users;
using Infrastructure.Persistence;
using Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using Domain.Utilities;

namespace Infrastructure.Repositories
{
    internal sealed class StaffRepository : BaseRepository, IStaffRepository
    {
        public StaffRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Staff> LoginAsync(string email, string password)
        {
            var staff = await _context.Staffs.FirstOrDefaultAsync(s => s.Email == email);

            if (staff == null || !PasswordHasher.VerifyPassword(password, staff.PasswordHash, staff.PasswordSalt))
            {
                throw new InvalidOperationException("Invalid email or password.");
            }

            return staff;
        }

        public async Task AddAsync(Staff staff)
        {
            await _context.Staffs.AddAsync(staff);
            await _context.SaveChangesAsync();
        }
    }
}
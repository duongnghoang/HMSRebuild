using Domain.Abstractions.Repositories;
using Domain.Entities.Users;
using Infrastructure.Persistence;
using Infrastructure.Repositories.Base;

namespace Infrastructure.Repositories
{
    internal sealed class StaffRepository : BaseRepository, IStaffRepository
    {
        public StaffRepository(ApplicationDbContext context) : base(context)
        {
        }

        public List<Staff> GetListOfStaff()
        {
            return _context.Staffs.ToList();
        }

        public Staff GetStaffById(Guid id)
        {
            return _context.Set<Staff>().FirstOrDefault(x => x.Id == id);
        }

        public Staff GetStaffByEmail(string email)
        {
            return _context.Staffs.FirstOrDefault(x => x.Email.Value == email);
        }

        public Staff GetStaffByEmailAndPassword(string email, string password)
        {
            return _context.Staffs.FirstOrDefault(x => x.Email.Value == email && x.Password == password);
        }

        public Staff AddStaff(Staff staff)
        {
            _context.Staffs.Add(staff);
            _context.SaveChanges();
            return staff;
        }

        public Staff UpdateStaff(Staff staff)
        {
            _context.Staffs.Update(staff);
            _context.SaveChanges();
            return staff;
        }
    }
}
using Domain.Entities.Users;

namespace Domain.Abstractions.Repositories
{
    public interface IStaffRepository
    {
        List<Staff> GetListOfStaff();

        Staff GetStaffById(Guid id);

        Staff GetStaffByEmail(string email);

        Staff GetStaffByEmailAndPassword(string email, string password);

        Staff AddStaff(Staff staff);

        Staff UpdateStaff(Staff staff);
    }
}
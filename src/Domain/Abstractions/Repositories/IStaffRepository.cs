using Domain.Abstractions.BaseObjects;
using Domain.Entities.Users;

namespace Domain.Abstractions.Repositories
{
    public interface IStaffRepository : IBaseRepository<Staff>
    {
        Task<Staff?> LoginAsync(string email, string password);

        Task AddAsync(Staff staff);
    }
}
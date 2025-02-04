using Domain.Entities.Users;

namespace Domain.Abstractions.Repositories
{
    public interface IStaffRepository
    {
        Task<Staff?> LoginAsync(string email, string password);

        Task AddAsync(Staff staff);
    }
}
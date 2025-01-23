using Domain.Entities.Users;

namespace Application.Interfaces
{
    public interface IJwtService
    {
        Task<string> GenerateTokenAsync(Staff staff);
    }
}
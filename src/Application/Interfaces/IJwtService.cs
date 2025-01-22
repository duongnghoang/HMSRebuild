using Domain.Entities.Users;

namespace Application.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(Staff staff);
    }
}
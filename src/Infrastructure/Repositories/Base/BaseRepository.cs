using Domain.Abstractions;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories.Base
{
    public class BaseRepository : IBaseRepository
    {
        protected readonly ApplicationDbContext _context;

        protected BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
using Domain.Abstractions.BaseObjects;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Base
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly ApplicationDbContext _context;

        protected BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task DeleteAsync(Guid id)
        {
            TEntity? entity = await _context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                throw new ArgumentNullException($"Entity {nameof(entity)} of id {id} is not found");
            }

            if (entity is ISoftDelete softDeletableEntity)
            {
                softDeletableEntity.DeletedAt = DateTime.UtcNow;
                var entityEntry = _context.Set<TEntity>().Attach(entity);
                entityEntry.State = EntityState.Modified;
                _context.Set<TEntity>().Update(entity);
            }
            else
            {
                _context.Set<TEntity>().Remove(entity);
            }

            await _context.SaveChangesAsync();
        }
    }
}
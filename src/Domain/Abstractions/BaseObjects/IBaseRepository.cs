namespace Domain.Abstractions.BaseObjects
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task DeleteAsync(Guid id);
    }
}
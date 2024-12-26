namespace Domain.BaseObjects
{
    public abstract class AggregateRoot : BaseEntity
    {
        protected AggregateRoot()
        {
        }

        protected AggregateRoot(Guid id) : base(id)
        {
        }
    }
}
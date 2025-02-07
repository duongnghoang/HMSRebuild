using System.ComponentModel.DataAnnotations;

namespace Domain.Abstractions.BaseObjects
{
    /// <summary>
    /// Base entity class
    /// </summary>
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
        }

        protected BaseEntity(Guid id)
        {
            Id = id;
        }

        /// <summary>
        /// Global unique identifier
        /// </summary>
        [Key]
        public Guid Id { get; protected set; } = Guid.NewGuid();
    }
}
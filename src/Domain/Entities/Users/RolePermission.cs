using Domain.BaseObjects;

namespace Domain.Entities.Users
{
    public class RolePermission : BaseEntity
    {
        public Guid RoleId { get; private set; }
        public Guid PermissionId { get; private set; }

        // Navigation properties
        public virtual Role? Role { get; private set; }
        public virtual Permission? Permission { get; private set; }
    }
}
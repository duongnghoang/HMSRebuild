using Domain.BaseObjects;

namespace Domain.Entities.Users
{
    public class Role : BaseEntity
    {
        public string? Name { get; private set; }
        public string? Description { get; private set; }
        public bool IsActive { get; private set; }

        public virtual ICollection<RolePermission>? RolePermissions { get; private set; }
    }
}
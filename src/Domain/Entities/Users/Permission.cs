using Domain.Abstractions.BaseObjects;

namespace Domain.Entities.Users
{
    public class Permission : BaseEntity
    {
        // Properties
        public string? Name { get; set; }
        public bool IsActive { get; set; } = true;

        // Self-referencing relationships
        public Guid? ParentPermissionId { get; set; }
        public virtual Permission? ParentPermission { get; set; }
        public virtual ICollection<Permission>? ChildPermissions { get; set; }
    }
}
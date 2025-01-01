using Domain.BaseObjects;

namespace Domain.Entities.Users
{
    public class Role : AggregateRoot
    {
        private readonly List<RolePermission> _rolePermissions;
        public string? Name { get; private set; }
        public string? Description { get; private set; }
        public bool IsActive { get; private set; }
        public IReadOnlyCollection<RolePermission> RolePermissions => _rolePermissions.AsReadOnly();
    }
}
using Domain.BaseObjects;

namespace Domain.Entities.Users
{
    public class RolePermission
    {
        public Guid RoleId { get; private set; }
        public Guid PermissionId { get; private set; }
    }
}
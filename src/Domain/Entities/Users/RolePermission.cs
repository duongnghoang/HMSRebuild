using Domain.BaseObjects;

namespace Domain.Entities.Users
{
    public class RolePermission
    {
        public Guid RoleId { get; set; }
        public Guid PermissionId { get; set; }
    }
}
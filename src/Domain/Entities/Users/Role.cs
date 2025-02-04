using Domain.Abstractions.BaseObjects;

namespace Domain.Entities.Users
{
    public class Role : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Staff>? Staffs { get; set; }
        public virtual ICollection<Permission>? Permissions { get; set; }
    }
}
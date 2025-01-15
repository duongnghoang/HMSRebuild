using Domain.BaseObjects;
using Domain.Entities.Common.EmailObject;

namespace Domain.Entities.Users
{
    public class Staff : BaseEntity
    {
        public string? Name { get; private set; }

        public Guid RoleId { get; private set; }

        public string? Email { get; private set; }

        public string? Password { get; private set; }

        public string? PhoneNumber { get; private set; }

        public DateTime? DateOfBirth { get; set; }

        public string? Address { get; set; }

        public bool Gender { get; set; }

        public byte[]? PasswordSalt { get; set; }

        public byte[]? PasswordHash { get; set; }

        public bool IsActive { get; private set; }

        public virtual Role? Role { get; private set; }
    }
}
using Domain.Abstractions.BaseObjects;

namespace Domain.Entities.Users
{
    public class Staff : BaseEntity
    {
        public string? Name { get; set; }

        public Guid? RoleId { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string? Address { get; set; }

        public bool Gender { get; set; }

        public byte[]? PasswordSalt { get; set; }

        public byte[]? PasswordHash { get; set; }

        public bool IsActive { get; set; }

        public virtual Role? Role { get; set; }
    }
}
using Domain.DomainCommon.Interface;
using Domain.Entities.Common;
using Domain.Entities.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities;

public class Staff : TimeStampTracking, IResponse<string>
{
    [Key]
    public string Id { get; set; } = Helper.DefaultStringPrimaryKey;
    public int? RoleId { get; set; }
    public string? StaffName { get; set; }
    public string Email { get; set; }

    public string? FullName { get; set; }
    public string? PhoneNumber { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? Address { get; set; }
    public bool IsMale { get; set; }
    public string? BankAccount { get; set; }
    public string? AvatarKeyUrl { get; set; }

    public byte[]? PasswordSalt { get; set; }
    public byte[]? PasswordHash { get; set; }

    public bool EmailVerified { get; set; } = false;
    public bool IsSuspended { get; set; }
    public DateTime? ExpireDate { get; set; }

    public bool IsHotelOwner { get; set; } = false;
    public bool IsAdmin { get; set; } = false;

    [ForeignKey(nameof(RoleId))]
    public virtual Role? Role { get; set; }
}

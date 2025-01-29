using Domain.DomainCommon.Interface;
using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace Domain.DevelopingEntities;

/// <summary>
/// Classname tên 'Guest' thay vì 'Customer'
/// Đối với khách đoàn, phân ra làm 2 loại khách
///     Khách đại diện (người đặt phòng, cũng là khách ở)
///     Khách ở (người khách chính của 1 phòng trong nhiều phòng mà đoàn đã đặt - ng cầm chìa khóa, ...)
/// </summary>
public class Guest : TimeStampTracking, IResponse<string>
{
    [Key]
    public string Id { get; set; } = Helper.DefaultStringPrimaryKey;
    public string Role { get; set; } = DomainConstant.RoleGuest;
    public string GuestName { get; set; } = DomainConstant.DefaultGuestName;

    /// <summary>
    /// Tên trên CMND/Hộ chiếu
    /// </summary>
    public string? IdentityName { get; set; }

    /// <summary>
    /// Số CMND/Hộ chiếu
    /// </summary>
    public string? IdentityNumber { get; set; }
    public string? Email { get; set; }
    public bool? Gender { get; set; }
    public DateTime? DateOfBirth { get; set; }

    /// <summary>
    /// Quốc tịch
    /// </summary>
    public string? Nationality { get; set; }
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// avatar of Guest
    /// data is an url of image, stored on cloud
    /// </summary>
    public string? AvatarKeyUrl { get; set; }
    public string? Address { get; set; }
    public string? Note { get; set; }

    //public string? Password { get; set; }
    public byte[]? PasswordSalt { get; set; }
    public byte[]? PasswordHash { get; set; }

    //[ForeignKey(nameof(RoleId))]
    //public Role? Role { get; set; }
}

using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities.RoomTypeFees;

/// <summary>
/// Quy tắc giá khi checkin/checkout ban ngày
/// </summary>
public class DayFee : IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public int FeePolicyId { get; set; }
    public bool IsActive { get; set; }
    public TimeSpan CheckInAt { get; set; }
    public TimeSpan CheckOutAt { get; set; }
    public decimal Fee { get; set; } = 0;
    public decimal? AdultAdditionalFee { get; set; }
    public decimal? ChildAdditionalFee { get; set; }
    public bool IsResideIn24h { get; set; } = false;

    [ForeignKey(nameof(FeePolicyId))]
    public virtual FeePolicy? FeePolicy { get; set; }

    /// <summary>
    /// check in ngoài khung giờ quy định sẽ tính thêm phí phạt
    /// </summary>
    //public virtual ICollection<PunishFee> PunishFees { get; set; }

}

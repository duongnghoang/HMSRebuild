using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities.RoomTypeFees;

public class MonthFee : IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public decimal Fee { get; set; } = 0;

    /// <summary>
    /// Tính theo số ngày thực tế của tháng (29, 30, hoặc 31 ngày) nếu true, 
    /// ngược lại mặc định là 30 ngày
    /// </summary>
    public bool UseActualDaysInMonth { get; set; } = false;

    public int FeePolicyId { get; set; }
    public bool IsActive { get; set; }

    [ForeignKey(nameof(FeePolicyId))]
    public virtual FeePolicy? FeePolicy { get; set; }
}

using Domain.Entities.Common;
using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;

namespace Domain.DevelopingEntities;

/// <summary>
/// Hình thức thanh toán như Tiền mặt, Chuyển khoản
/// </summary>
public class PaymentMethod : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public Entities.Common.Enumeration.Definition.PaymentMethod Name { get; set; } = Entities.Common.Enumeration.Definition.PaymentMethod.Cash;
}

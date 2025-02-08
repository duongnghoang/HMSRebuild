using Domain.Entities.Common;
using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

/// <summary>
/// Hình thức thanh toán như Tiền mặt, Chuyển khoản
/// </summary>
public class PaymentMethod : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public Common.Enumeration.Definition.PaymentMethod Name { get; set; } = Common.Enumeration.Definition.PaymentMethod.Cash;
}

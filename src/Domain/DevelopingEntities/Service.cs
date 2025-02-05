using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Domain.Entities.Common.Interface;

namespace Domain.DevelopingEntities;

public class Service : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public int ServiceGroupId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Unit { get; set; }
    /// <summary>
    /// Giá có thể thay đổi trong lúc mua trực tiếp theo lễ tân, không ảnh hưởng tới giá gốc
    /// </summary>
    public bool CanFixPrice { get; set; }
    /// <summary>
    /// Số lượng tối thiểu : Cảnh báo trong “Báo Cáo Kho” khi số lượng nhỏ hơn số lượng tối thiểu
    /// </summary>
    public int MinimumQuantity { get; set; }
    /// <summary>
    /// Được quản lý nhập kho: khi tích chọn thì dịch vụ sẽ tự trừ số lượng khi sử dụng để ra số tồn kho
    /// </summary>
    public bool CanManageWarehouse { get; set; }
    /// <summary>
    /// Không được thêm vào hóa đơn: khi tích chọn thì dịch vụ này sẽ không xuất hiện trong dịch vụ phòng cũng như điểm bán hàng
    /// </summary>
    public bool DoNotAddToInvoice { get; set; }
    public bool IsActive { get; set; }

    [ForeignKey(nameof(ServiceGroupId))]
    public virtual ServiceGroup? ServiceGroup { get; set; }

}

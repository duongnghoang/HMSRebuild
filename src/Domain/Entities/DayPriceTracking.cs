using Domain.Entities.Common;
using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;
/// <summary>
/// Đây là entity cho giá tiền của từng ngày
/// ví dụ ngày 1 : 450k (Được sửa giá)
/// ngày 2: 500k
/// ngày 3: 500k
/// ứng với mỗi ngày sẽ có một giá khác nhau tượng trưng cho một record
/// </summary>

public class DayPriceTracking : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public int ReservationRoomId { get; set; }
    public decimal? Price { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    [ForeignKey(nameof(ReservationRoomId))]
    public virtual ReservationRoom? ReservationRoom { get; set; }

}

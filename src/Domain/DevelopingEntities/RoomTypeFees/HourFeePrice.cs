using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities.RoomTypeFees
{
    public class HourFeePrice : IResponse<int>
    {
        [Key]
        public int Id { get; set; }
        public TimeSpan Hour { get; set; }
        public decimal Price { get; set; }
        public int HourFeeId { get; set; }
        [ForeignKey(nameof(HourFeeId))]
        public virtual HourFee? HourFee { get; set; }
    }
}

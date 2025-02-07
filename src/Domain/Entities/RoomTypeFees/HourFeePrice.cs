using Domain.Abstractions.BaseObjects;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.RoomTypeFees
{
    public class HourFeePrice : BaseEntity
    {
        public string Hour { get; set; }
        public decimal Price { get; set; }
        public Guid HourFeeId { get; set; }

        [ForeignKey(nameof(HourFeeId))]
        public virtual HourFee? HourFee { get; set; }
    }
}
using Domain.DomainCommon.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.RoomFee
{
    public class HourFeePrice : IResponse<int>
    {
        [Key]
        public int Id { get; set; }
        public string Hour { get; set; }
        public decimal Price { get; set; }
        public int HourFeeId {  get; set; }
        [ForeignKey(nameof(HourFeeId))]
        public virtual HourFee? HourFee { get; set; }
    }
}

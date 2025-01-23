using Domain.DomainCommon.Interface;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Common
{
    public class TimeStampTracking : CreatedModifiedTracking, ISoftDelete
    {
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }
    }

    public class CreatedModifiedTracking : ICreatedModifiedTracking
    {
        [Column(TypeName = "smalldatetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column(TypeName = "smalldatetime")]
        public DateTime? ModifiedAt { get; set; }
    }
}

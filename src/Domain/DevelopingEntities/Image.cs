using Domain.Entities.Common;
using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities
{
    public class Image : TimeStampTracking, IResponse<int>
    {
        [Key]
        public int Id { get; set; }
        public int RoomId { get; set; }
        public string InitialName { get; set; }
        public string FileExtension { get; set; }
        public string CloudName { get; set; }
        public string? Description { get; set; }

        [ForeignKey(nameof(RoomId))]
        public virtual Room? Room { get; set; }
    }
}

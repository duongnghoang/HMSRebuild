using Domain.DomainCommon.Interface;
using Domain.DomainCommon;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Building : TimeStampTracking, IResponse<int>
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        // Tọa độ để hiển thị trên bản đồ
        public float? PositionX { get; set; }
        public float? PositionY { get; set; }
        // Kích thước hiển thị
        public float? Width { get; set; } 
        public float? Height { get; set; }

    }
}

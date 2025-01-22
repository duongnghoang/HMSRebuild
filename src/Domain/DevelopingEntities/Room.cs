﻿using Domain.DevelopingEntities;
using Domain.DomainCommon;
using Domain.DomainCommon.Enumeration.Definition;
using Domain.DomainCommon.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity;

public class Room : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public string RoomName { get; set; }
    public int FloorId { get; set; }
    public int RoomTypeId { get; set; }
    public int Order { get; set; } = 0;
    public RoomStatus RoomStatus { get; set; }

    /// <summary>
    /// Phòng bẩn/sạch
    /// </summary>
    public bool IsCleaning { get; set; }

    /// <summary>
    /// Phòng có đang trong quá trình sửa chữa
    /// </summary>
    public bool IsRepairing { get; set; }

    [ForeignKey(nameof(FloorId))]
    public virtual Floor? Floor { get; set; }

    [ForeignKey(nameof(RoomTypeId))]
    public virtual RoomType? RoomType { get; set; }
}

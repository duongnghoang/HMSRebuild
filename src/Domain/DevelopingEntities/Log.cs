﻿using Domain.DomainCommon.Interface;
using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities;

public class Log : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public string StaffId { get; set; }
    public string Detail {  get; set; }

    [ForeignKey(nameof(StaffId))]
    public Staff Staff { get; set; }
}

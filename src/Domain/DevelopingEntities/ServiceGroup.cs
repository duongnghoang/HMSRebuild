﻿using Domain.DomainCommon.Interface;
using Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities;

public class ServiceGroup : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int ServiceCategoryId { get; set; }

    [ForeignKey(nameof(ServiceCategoryId))]
    public virtual ServiceCategory? ServiceCategory { get; set; }
}

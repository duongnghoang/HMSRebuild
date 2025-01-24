﻿using Domain.DomainCommon.Interface;
using System.ComponentModel.DataAnnotations;

namespace Domain.DevelopingEntities.BookingType;

public class Market : IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public bool IsActived { get; set; }
}

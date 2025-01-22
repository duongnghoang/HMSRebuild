﻿using Domain.DomainCommon.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity.RoomFee;

public class MonthFee : IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public decimal Fee { get; set; } = 0;
    public bool WhenToCalculate { get; set; } = false;
    public int FeePolicyId { get; set; }
    public bool IsInUsed { get; set; } = false;

    [ForeignKey(nameof(FeePolicyId))]
    public virtual FeePolicy? FeePolicy { get; set; }
}

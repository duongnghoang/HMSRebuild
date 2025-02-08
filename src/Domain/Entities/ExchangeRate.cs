using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class ExchangeRate : IResponse<int>
{
    [Key]
    public int Id { get; set; }
    /// <summary>
    /// Ví dụ VND - Dong
    /// </summary>
    public string DefaultCurrency { get; set; }
    /// <summary>
    /// Ví dụ USD - US Dollar
    /// </summary>
    public string ForeignCurrency { get; set; }
    /// <summary>
    /// Giá quy đổi từ Foreign qua Defaul (ví dụ 1USD = 25000 VND)
    /// </summary>
    public string ConvertedInto { get; set; }
}

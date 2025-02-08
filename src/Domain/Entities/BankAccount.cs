using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;
/// <summary>
/// 
/// </summary>
public class BankAccount : IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public string AccountNumber { get; set; }
    public string Name { get; set; }
    public string Branch { get; set; }
}

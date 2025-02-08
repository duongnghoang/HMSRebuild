using Domain.Entities.Common;
using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Supplier : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? PhoneNumber { get; set; }
    public string? MobileNumber { get; set; }
    public string? Email { get; set; }
    public string? Fax { get; set; }

    // Contact Person Information
    public string? ContactPersonName { get; set; }
    public string? ContactPersonMobile { get; set; }
    public string? ContactPersonEmail { get; set; }
    public string? Vat { get; set; }
}

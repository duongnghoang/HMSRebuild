using Domain.DomainCommon.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DevelopingEntities.BookingType;

public class Company : IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string? ContactNumber { get; set; }
    public string? Email { get; set; }
    public string? MobilePhoneNumber { get; set; }
    public string? FaxNumber { get; set; }
    public string? TaxCode { get; set; }
    public string? Description { get; set; }
    public int SourceId { get; set; }
    // Contact Person Information
    public string? ContactPersonName { get; set; }
    public string? ContactPersonMobile { get; set; }
    public string? ContactPersonEmail { get; set; }
    public string? ContactPersonAddress { get; set; }
    public string? ContactPersonPosition { get; set; }

    [ForeignKey(nameof(SourceId))]
    public Source? Source { get; set; }

}

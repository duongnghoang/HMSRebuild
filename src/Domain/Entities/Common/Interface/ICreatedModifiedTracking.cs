namespace Domain.DomainCommon.Interface;

public interface ICreatedModifiedTracking
{
    DateTime CreatedAt { get; set; }
    DateTime? ModifiedAt { get; set; }
}

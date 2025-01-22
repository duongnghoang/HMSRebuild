namespace Domain.DomainCommon.Interface;

public interface ISoftDelete
{
    DateTime? DeletedAt { get; set; }
}

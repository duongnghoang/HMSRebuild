namespace Domain.DomainCommon.Interface
{
    public interface IResponse<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }
}

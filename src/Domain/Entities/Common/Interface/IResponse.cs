namespace Domain.Entities.Common.Interface
{
    public interface IResponse<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }
}

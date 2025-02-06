namespace Domain.Abstractions.BaseObjects
{
    public interface ISoftDelete
    {
        DateTime? DeletedAt { get; set; }
    }
}
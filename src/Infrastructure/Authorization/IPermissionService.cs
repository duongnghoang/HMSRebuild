namespace Infrastructure.Authorization
{
    public interface IPermissionService
    {
        Task<HashSet<string>> GetPermissionsAsync(Guid staffId);
    }
}
namespace Infrastructure.Services.Authorization
{
    public interface IPermissionService
    {
        Task<HashSet<string>> GetPermissionsAsync(Guid staffId);
    }
}
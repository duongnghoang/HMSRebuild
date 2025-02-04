using Microsoft.AspNetCore.Authorization;

namespace Infrastructure.Services.Authorization
{
    public class PermissionRequirement : IAuthorizationRequirement
    {
        public PermissionRequirement(params string[] permissions)
        {
            Permissions = permissions;
        }

        public string[] Permissions { get; }
    }
}
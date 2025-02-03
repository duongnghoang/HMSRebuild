using Domain.Entities.Users;
using Domain.Shared.Permissions;
using Microsoft.AspNetCore.Authorization;

namespace Infrastructure.Authorization
{
    public class HasPermissionAttribute : AuthorizeAttribute
    {
        public HasPermissionAttribute(params string[] permissions) : base(policy: string.Join(",", permissions))
        {
        }
    }
}
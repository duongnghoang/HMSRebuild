using Microsoft.AspNetCore.Authorization;

namespace Infrastructure.Services.Authorization
{
    public class HasPermissionAttribute : AuthorizeAttribute
    {
        public HasPermissionAttribute(params string[] permissions) : base(policy: string.Join(",", permissions))
        {
        }
    }
}
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Authorization
{
    public class PermissionAuthorizationHandler : AuthorizationHandler<PermissionRequirement>
    {
        //private readonly IServiceScopeFactory _serviceScopeFactory;

        //public PermissionAuthorizationHandler(IServiceScopeFactory serviceScopeFactory)
        //{
        //    _serviceScopeFactory = serviceScopeFactory;
        //}

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
            PermissionRequirement requirement)
        {
            HashSet<string> permissions = context.User.Claims
                .Where(x => x.Type == CustomClaims.Permissions)
                .Select(x => x.Value).ToHashSet();

            if (requirement.Permissions.Intersect(permissions).Any())
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
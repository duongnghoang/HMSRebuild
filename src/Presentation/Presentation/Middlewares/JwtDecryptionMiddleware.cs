using Application.Interfaces;
using Infrastructure.Services.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Presentation.Middlewares
{
    public class JwtDecryptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public JwtDecryptionMiddleware(RequestDelegate next, IServiceScopeFactory serviceScopeFactory)
        {
            _next = next;
            _serviceScopeFactory = serviceScopeFactory;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var jwtService = scope.ServiceProvider.GetRequiredService<IJwtService>();
                var authHeader = context.Request.Headers["Authorization"].FirstOrDefault();
                if (authHeader != null && authHeader.StartsWith("Bearer "))
                {
                    var encryptedToken = authHeader.Substring("Bearer ".Length).Trim();
                    var decryptedToken = jwtService.DecryptJwt(encryptedToken);
                    context.Request.Headers["Authorization"] = $"Bearer {decryptedToken}";
                }
            }

            await _next(context);
        }
    }
}
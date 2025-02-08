using Application.Interfaces;
using Domain.Abstractions.Repositories;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Settings;
using Infrastructure.Repositories;
using Infrastructure.Services.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Domain.Abstractions.BaseObjects;
using Infrastructure.Persistence.Interceptors;
using Infrastructure.Repositories.Base;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            // Configure AppsettingOptions
            services.Configure<ConnectionStrings>(configuration.GetSection("ConnectionStrings"));
            services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));
            services.Configure<Loggings>(configuration.GetSection("Loggings"));
            services.Configure<AesEncryptionSettings>(configuration.GetSection("AesEncryption"));

            services.AddSingleton<UpdateAuditableEntitiesInterceptor>();

            // Configure DbContext
            services.AddDbContext<ApplicationDbContext>((serviceProvider, options) =>
            {
                var connectionStrings = serviceProvider.GetRequiredService<IOptions<ConnectionStrings>>().Value;
                var auditableInterceptor = serviceProvider.GetRequiredService<UpdateAuditableEntitiesInterceptor>();
                if (!options.IsConfigured)
                {
                    options.UseSqlServer(connectionStrings.DefaultConnection)
                        .AddInterceptors(auditableInterceptor);
                }
            });

            // Add JWT Authentication
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                var jwtSettings = configuration.GetSection("JwtSettings").Get<JwtSettings>();
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtSettings.Issuer,
                    ValidAudience = jwtSettings.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(jwtSettings.Secret))
                };
            });

            //Add Authorization services to the DI container
            services.AddAuthorization();
            services.AddSingleton<IAuthorizationHandler, PermissionAuthorizationHandler>();
            services.AddSingleton<IAuthorizationPolicyProvider, PermissionAuthorizationPolicyProvider>();
            services.AddScoped<IJwtService, JwtService>();
            services.AddScoped<IPermissionService, PermissionService>();

            // Register Repositories
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IStaffRepository, StaffRepository>();

            return services;
        }
    }
}
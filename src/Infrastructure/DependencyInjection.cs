using Application.Interfaces;
using Domain.Abstractions.Repositories;
using Infrastructure.Authorization;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Settings;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authorization;

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

            // Configure DbContext
            services.AddDbContext<ApplicationDbContext>((serviceProvider, options) =>
            {
                var connectionStrings = serviceProvider.GetRequiredService<IOptions<ConnectionStrings>>().Value;
                if (!options.IsConfigured)
                {
                    options.UseSqlServer(connectionStrings.DefaultConnection);
                }
            });

            // Add JWT Authentication if needed
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

            services.AddAuthorization();
            services.AddSingleton<IAuthorizationHandler, PermissionAuthorizationHandler>();
            services.AddSingleton<IAuthorizationPolicyProvider, PermissionAuthorizationPolicyProvider>();

            services.AddScoped<IStaffRepository, StaffRepository>();
            services.AddScoped<IJwtService, JwtService>();
            return services;
        }
    }
}
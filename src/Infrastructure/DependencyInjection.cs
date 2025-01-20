using System.Text;
using Domain.Abstractions;
using Domain.Abstractions.Repositories;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Settings;
using Infrastructure.Repositories;
using Infrastructure.Repositories.Base;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            // Configure AppSettingOptions
            services.Configure<AppsettingsOption>(configuration);

            // Configure DbContext
            services.AddDbContext<ApplicationDbContext>((serviceProvider, options) =>
            {
                var appSettings = serviceProvider.GetRequiredService<IOptions<AppsettingsOption>>();
                options.UseSqlServer(appSettings.Value.ConnectionString!.DefaultConnection);
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
            services.ConfigureOptions<AppsettingsOptionSetup>();

            // Then configure and register the DbContext
            services.AddDbContext<ApplicationDbContext>((serviceProvider, options) =>
            {
                var appsettings = serviceProvider.GetRequiredService<IOptions<AppsettingsOption>>().Value;
                if (!options.IsConfigured)
                {
                    options.UseSqlServer(appsettings.ConnectionString?.DefaultConnection);
                }
            });

            services.AddScoped<IStaffRepository, StaffRepository>();

            return services;
        }
    }
}
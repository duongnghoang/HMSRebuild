using Domain.Abstractions;
using Domain.Abstractions.Repositories;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Settings;
using Infrastructure.Repositories;
using Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
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

            services.AddScoped<typeof(IBaseRepository), typeof(BaseRepository)>();
            return services;
        }
    }
}
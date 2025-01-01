using Infrastructure.Persistence.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            // Navigate to the Web API project directory
            var webApiProjectPath = Path.Combine(Directory.GetCurrentDirectory(), "..", "WebApi");
            // Load configuration
            var configuration = new ConfigurationBuilder()
                .SetBasePath(webApiProjectPath)
                .AddJsonFile("appsettings.json")
                .Build();

            // Manually bind AppsettingsOption
            var appsettings = new AppsettingsOption();
            configuration.Bind(appsettings);

            // Configure DbContext options
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(appsettings.ConnectionString?.DefaultConnection);

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
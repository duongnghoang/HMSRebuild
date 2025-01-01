using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Infrastructure.Persistence.Settings
{
    public class AppsettingsOptionSetup : IConfigureOptions<AppsettingsOption>
    {
        private readonly IConfiguration _configuration;

        public AppsettingsOptionSetup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Configure(AppsettingsOption options)
        {
            _configuration.Bind(options);
        }
    }
}
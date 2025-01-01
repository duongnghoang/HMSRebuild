namespace Infrastructure.Persistence.Settings
{
    public class AppsettingsOption
    {
        public ConnectionStrings? ConnectionString { get; set; }
        public JwtSettings? JwtSetting { get; set; }
        public Loggings? Logging { get; set; }
        public string? AllowedHosts { get; set; }
    }

    public class Loggings
    {
        public Dictionary<string, string>? LogLevel { get; set; }
    }

    public class JwtSettings
    {
        public string? Secret { get; set; }
        public string? Issuer { get; set; }
        public string? Audience { get; set; }
        public int? AccessTokenExpiration { get; set; }
        public int? RefreshTokenExpiration { get; set; }
    }

    public class ConnectionStrings
    {
        public string? DefaultConnection { get; set; }
    }
}
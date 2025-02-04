namespace Infrastructure.Persistence.Settings
{
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
        public string DefaultConnection { get; set; } = string.Empty;
    }

    public class AesEncryptionSettings
    {
        public string? Key { get; set; }
        public string? IV { get; set; }
    }
}
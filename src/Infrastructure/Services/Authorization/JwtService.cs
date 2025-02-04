using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Application.Interfaces;
using Domain.Entities.Users;
using Infrastructure.Persistence.Settings;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Infrastructure.Services.Authorization
{
    public class JwtService : IJwtService
    {
        private readonly JwtSettings _jwtSettings;
        private readonly IPermissionService _permissionService;
        private readonly AesEncryptionSettings _aesEncryptionSettings;

        public JwtService(IOptions<JwtSettings> jwtSettings, IPermissionService permissionService,
            IOptions<AesEncryptionSettings> aesEncryptionSettings)
        {
            _permissionService = permissionService;
            _jwtSettings = jwtSettings.Value;
            _aesEncryptionSettings = aesEncryptionSettings.Value;
        }

        // Encrypts a JWT token using AES
        private string EncryptJwt(string token)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(_aesEncryptionSettings.Key);
                aes.IV = Encoding.UTF8.GetBytes(_aesEncryptionSettings.IV);

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                byte[] tokenBytes = Encoding.UTF8.GetBytes(token);
                byte[] encryptedBytes = encryptor.TransformFinalBlock(tokenBytes, 0, tokenBytes.Length);

                return Convert.ToBase64String(encryptedBytes);
            }
        }

        // Decrypts an encrypted JWT token
        public string DecryptJwt(string encryptedToken)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(_aesEncryptionSettings.Key);
                aes.IV = Encoding.UTF8.GetBytes(_aesEncryptionSettings.IV);

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                byte[] encryptedBytes = Convert.FromBase64String(encryptedToken);
                byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }

        public async Task<string> GenerateTokenAsync(Staff staff)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, staff.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, staff.Email!)
            };

            HashSet<string> permissions = await _permissionService
                .GetPermissionsAsync(staff.Id);

            foreach (string permission in permissions)
            {
                claims.Add(new Claim(CustomClaims.Permissions, permission));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Secret!));
            var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var tokenOptions = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(_jwtSettings.AccessTokenExpiration ?? 30),
                signingCredentials: signingCredentials);

            string tokenValue = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            return EncryptJwt(tokenValue);
        }
    }
}
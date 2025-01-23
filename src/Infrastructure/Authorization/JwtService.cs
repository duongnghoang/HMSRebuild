using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Application.Interfaces;
using Domain.Entities.Users;
using Infrastructure.Persistence.Settings;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Infrastructure.Authorization
{
    public class JwtService : IJwtService
    {
        private readonly JwtSettings _jwtSettings;
        private readonly IPermissionService _permissionService;

        public JwtService(IOptions<JwtSettings> jwtSettings, IPermissionService permissionService)
        {
            _permissionService = permissionService;
            _jwtSettings = jwtSettings.Value;
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
            return tokenValue;
        }
    }
}
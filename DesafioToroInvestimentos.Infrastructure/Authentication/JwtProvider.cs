using DesafioToroInvestimentos.Domain.Configuration.JWT;
using DesafioToroInvestimentos.Domain.Entities.User;
using DesafioToroInvestimentos.Domain.Interfaces.Services.JWT;
using DesafioToroInvestimentos.Domain.Responses;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DesafioToroInvestimentos.Infrastructure.Authentication
{
    public class JwtProvider : IJwtProvider
    {
        private readonly JWTConfiguration _jwtConfiguration;

        public JwtProvider(IOptions<JWTConfiguration> options)
        {
            _jwtConfiguration = options.Value;
        }

        public TokenResponse Generate(UserEntity user)
        {
            var claims = new Claim[] 
            { 
                new(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new(JwtRegisteredClaimNames.Email, user.Email)
            };

            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(_jwtConfiguration.Secret)), SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                _jwtConfiguration.EmitedBy,
                _jwtConfiguration.ValidatedIn,
                claims,
                null,
                DateTime.UtcNow.AddHours(_jwtConfiguration.ExpirationInHour),
                signingCredentials
                );

            var tokenValue = new TokenResponse()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                ExpireIn = _jwtConfiguration.ExpirationInHour
            };

            return tokenValue;
        }
    }
}

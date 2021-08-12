using CrawfordClaimsHandler.Api.CoreWebApi.DomainEntities;
using CrawfordClaimsHandler.Api.CoreWebApi.Options;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CrawfordClaimsHandler.Api.CoreWebApi.JwtToken
{
    public class JwtHandler
    {
        private readonly IConfiguration _configuration;
        private readonly JwtTokenOptions _jwtTokenOptions;
        public JwtHandler(IConfiguration configuration)
        {
            _configuration = configuration;
            _jwtTokenOptions = new JwtTokenOptions();
            _configuration.GetSection(JwtTokenOptions.JWT).Bind(_jwtTokenOptions);
        }
        public SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(_jwtTokenOptions.SecurityKey);
            var secret = new SymmetricSecurityKey(key);
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }
        public List<Claim> GetClaims(User user)
        {
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.UserName)
        };
            return claims;
        }
        public JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var tokenOptions = new JwtSecurityToken(
                issuer: _jwtTokenOptions.ValidIssuer,
                audience: _jwtTokenOptions.ValidAudience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(_jwtTokenOptions.ExpiryInMinutes)),
                signingCredentials: signingCredentials);
            return tokenOptions;
        }
    }
}

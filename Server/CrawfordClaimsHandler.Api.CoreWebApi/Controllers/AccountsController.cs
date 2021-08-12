using CrawfordClaimsHandler.Api.CoreWebApi.Data.Contracts;
using CrawfordClaimsHandler.Api.CoreWebApi.DomainEntities;
using CrawfordClaimsHandler.Api.CoreWebApi.JwtToken;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace CrawfordClaimsHandler.Api.CoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly JwtHandler _jwtHandler;
        public AccountsController(IUserService userService, JwtHandler jwtHandler)
        {
            _userService = userService;
            _jwtHandler = jwtHandler;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] Login login)
        {
            var user = await _userService.GetUserByUsernameAsync(login.UserName);
            // check if there is a active user
            if (user != null && !user.Active)
                return Unauthorized(new AuthResponse { ErrorMessage = "User is not active" });
            // check if user password match
            if (user == null || !user.Password.Equals((login.Password)))
                return Unauthorized(new AuthResponse { ErrorMessage = "Invalid Authentication" });
            var signingCredentials = _jwtHandler.GetSigningCredentials();
            var claims = _jwtHandler.GetClaims(user);
            var tokenOptions = _jwtHandler.GenerateTokenOptions(signingCredentials, claims);
            var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            return Ok(new AuthResponse { IsAuthSuccessful = true, Token = token });
        }

    }
}

﻿using CrawfordClaimsHandler.Api.CoreWebApi.Data.Contracts;
using CrawfordClaimsHandler.Api.CoreWebApi.Data.Repository;
using CrawfordClaimsHandler.Api.CoreWebApi.Options;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawfordClaimsHandler.Api.CoreWebApi.Extensions
{
public static class TokenExtensions
{
        public static IServiceCollection AddJwtAuthentication(this IServiceCollection services, JwtTokenOptions jwtTokenOptions)
        {
            
            services.AddAuthentication(opt =>
            {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtTokenOptions.ValidIssuer,
                    ValidAudience = jwtTokenOptions.ValidAudience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtTokenOptions.SecurityKey))
                };
            });

            return services;
        }
    }
}

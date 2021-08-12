using CrawfordClaimsHandler.Api.CoreWebApi.Data.Contracts;
using CrawfordClaimsHandler.Api.CoreWebApi.Data.Repository;
using CrawfordClaimsHandler.Api.CoreWebApi.Data.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawfordClaimsHandler.Api.CoreWebApi.Extensions
{
    public static class DataServiceExtensions
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services)
        {
            services.AddScoped<ILossTypeService, LossTypeService>();
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}

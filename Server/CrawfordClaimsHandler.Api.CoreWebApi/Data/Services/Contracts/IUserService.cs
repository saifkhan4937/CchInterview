using CrawfordClaimsHandler.Api.CoreWebApi.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawfordClaimsHandler.Api.CoreWebApi.Data.Contracts
{
    public interface IUserService
    {
        public Task<User> GetUserByUsernameAsync(string userName);
        public Task<IEnumerable<User>> GetAllUsersAsync();
    }
}

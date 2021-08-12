using CrawfordClaimsHandler.Api.CoreWebApi.Contracts;
using CrawfordClaimsHandler.Api.CoreWebApi.Data.Contracts;
using CrawfordClaimsHandler.Api.CoreWebApi.DomainEntities;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawfordClaimsHandler.Api.CoreWebApi.Data.Repository
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(IConfiguration configuration)
           : base(configuration)
        { }

        public async Task<User> GetUserByUsernameAsync(string userName)
        {
            try
            {
                var query = "SELECT * FROM Users  WHERE UserName = @UserName";
                using var connection = CreateConnection();
                return (await connection.QuerySingleOrDefaultAsync<User>(query, new { UserName = userName }));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            try
            {
                var query = "SELECT * FROM Users";
                using var connection = CreateConnection();
                return (await connection.QueryAsync<User>(query));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}

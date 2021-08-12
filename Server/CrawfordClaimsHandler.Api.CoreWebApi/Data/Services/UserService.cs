using CrawfordClaimsHandler.Api.CoreWebApi.Data.Contracts;
using CrawfordClaimsHandler.Api.CoreWebApi.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawfordClaimsHandler.Api.CoreWebApi.Data.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetUserByUsernameAsync(string userName)
        {
            return await _userRepository.GetUserByUsernameAsync(userName);
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }
    }
}

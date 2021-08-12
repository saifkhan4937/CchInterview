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
    public class LossTypeRepository: BaseRepository, ILossTypeRepository
    {
        public LossTypeRepository(IConfiguration configuration)
           : base(configuration)
        { }

        public async Task<IEnumerable<LossType>> GetAllAsync()
        {
            try
            {
                var query = "SELECT * FROM LossTypes";
                using var connection = CreateConnection();
                // For now we have been using Entity class "LossType", In real project we should use DTO taking data from DB then map it to Entity class.
                return (await connection.QueryAsync<LossType>(query));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}

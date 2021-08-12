using CrawfordClaimsHandler.Api.CoreWebApi.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawfordClaimsHandler.Api.CoreWebApi.Data.Contracts
{
    public interface ILossTypeService
    {
        public Task<IEnumerable<LossType>> GetAllLossTypesAsync();
    }
}

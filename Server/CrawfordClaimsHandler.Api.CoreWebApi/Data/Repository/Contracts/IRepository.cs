using CrawfordClaimsHandler.Api.CoreWebApi.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawfordClaimsHandler.Api.CoreWebApi.Contracts
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
    }
}

using CrawfordClaimsHandler.Api.CoreWebApi.Data.Contracts;
using CrawfordClaimsHandler.Api.CoreWebApi.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawfordClaimsHandler.Api.CoreWebApi.Data.Services
{
    public class LossTypeService : ILossTypeService
    {
        private readonly ILossTypeRepository _lossTypeRepository;

        public LossTypeService(ILossTypeRepository lossTypeRepository)
        {
            _lossTypeRepository = lossTypeRepository;
        }

        public async Task<IEnumerable<LossType>> GetAllLossTypesAsync()
        {
            return await _lossTypeRepository.GetAllAsync();
        }
    }
}

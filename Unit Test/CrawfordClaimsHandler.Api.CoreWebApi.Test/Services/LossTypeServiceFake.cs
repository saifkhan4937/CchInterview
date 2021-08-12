using CrawfordClaimsHandler.Api.CoreWebApi.Data.Contracts;
using CrawfordClaimsHandler.Api.CoreWebApi.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawfordClaimsHandler.Api.CoreWebApi.Test.Services
{
    public class LossTypeServiceFake : ILossTypeService
    {
        private readonly IEnumerable<LossType> _lossTypes;

        public LossTypeServiceFake(){
            _lossTypes = new List<LossType>()
            {
                new LossType() {LossTypeId = 1, LossTypeCode = "A", LossTypeDescription = "desc A", Active = true},
                new LossType() {LossTypeId = 2, LossTypeCode = "B", LossTypeDescription = "desc B", Active = true},
                new LossType() {LossTypeId = 3, LossTypeCode = "C", LossTypeDescription = "desc C", Active = false}   
    };
}

        public async Task<IEnumerable<LossType>> GetAllLossTypesAsync()
        {
            return await Task.Run( () => _lossTypes);
        }
    }
}

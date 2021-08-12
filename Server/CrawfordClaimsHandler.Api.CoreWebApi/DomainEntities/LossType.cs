using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawfordClaimsHandler.Api.CoreWebApi.DomainEntities
{
    public class LossType: BaseEntity
    {
        public int LossTypeId { get; set; }
        public string LossTypeCode { get; set; }
        public string LossTypeDescription { get; set; }
        public bool Active { get; set; }
    }
}

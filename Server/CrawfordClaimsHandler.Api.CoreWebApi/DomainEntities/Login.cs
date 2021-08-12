using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawfordClaimsHandler.Api.CoreWebApi.DomainEntities
{
    public class Login
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

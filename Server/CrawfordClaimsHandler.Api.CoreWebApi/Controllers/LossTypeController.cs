using CrawfordClaimsHandler.Api.CoreWebApi.Data.Contracts;
using CrawfordClaimsHandler.Api.CoreWebApi.DomainEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrawfordClaimsHandler.Api.CoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class LossTypeController : ControllerBase
    {
        private readonly ILossTypeService _lossTypeService;

        public LossTypeController(ILossTypeService lossTypeService)
        {
            _lossTypeService = lossTypeService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LossType>>> GetAsync()
        {
            var lossTypes = await _lossTypeService.GetAllLossTypesAsync();
            if (lossTypes == null)
            {
                return NotFound();
            }
            return Ok(lossTypes);
        }

    }
}

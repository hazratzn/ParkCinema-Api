using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Park_Cinema.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RulesController : ControllerBase
    {
        private readonly IRulesService _rulesService;


        public RulesController(IRulesService rulesService)
        {
            _rulesService = rulesService;
        }

        [HttpGet("GetRule")]
        public async Task<IActionResult> GetRules()
        {
            var rules=   await _rulesService.GetAllRulesAsync();
            return Ok(rules);
        }
    }
}

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
    public class HallController : ControllerBase
    {
        private readonly IHallService  _hallService;

        public HallController(IHallService hallService)
        {
            _hallService = hallService;
        }

        [HttpGet("GetHallById/{id}")]
        public async Task<IActionResult> GetMovies([FromRoute] int id) 
        {
            var halls = await _hallService.GetHallsByBranchId(id);
            if (halls == null)
            {
                return NotFound();
            }
            return Ok(halls);
        }
    }
}

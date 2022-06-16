using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Park_Cinema.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionsController : ControllerBase
    {
        private readonly ISessionService _service;

        public SessionsController(ISessionService service)
        {
            _service = service;
        }

        [HttpGet("GetSessionByMovieId/{movieId}")]
        public async Task<IActionResult> GetSessionsByMovieId(int movieId)
        {
            if(movieId == null)
            {
                return NotFound();
            }
            var movieSession = await _service.GetSessionsByMovieId(movieId);

            if (movieSession == null)
            {
                return NotFound();
            }

            return Ok(movieSession);
        }

        [HttpGet("GetSessionsByBranchId/{branchId}")]
        public async Task<IActionResult> GetSessionByBranchId(int branchId, [FromHeader] string language)
        {
            var branchSessions = await _service.GetSessionByBranchId(branchId, language);
            if(branchSessions  == null)
            {
                return Content("tapilmadi");
            }
            return Ok(branchSessions);
        }
        [HttpGet("GetSessionsByFormat")]
        public async Task<IActionResult> GetSessionByFormat(string format)
        {


            var branchSessions = await _service.GetSessionByFormat(format);
            if (branchSessions == null)
            {
                return Content("tapilmadi");
            }
            return Ok(branchSessions);
        }
    }
}

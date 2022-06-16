using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Park_Cinema.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IBranchService _service;

        public BranchController(IBranchService service)
        {
            _service = service;
        }

        [HttpGet("/GetAboutUs")]
        public async Task<IActionResult> GetAboutUs([FromHeader] string language)
        {
            var data = await _service.GetAboutUs(language);
            return Ok(data);
        }
        

        [HttpGet("GetBranches")]
        public async Task<IActionResult> GetBranches([FromHeader] string language)
        {
            var data = await _service.GetBranches(language);
            return Ok(data);
        }
        [HttpGet("GetBranch/{id}")]
        public async Task<IActionResult> GetBranchById([FromRoute] int id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var branchDetail = await _service.GetBranchDetailByIdAsync(id);
            return Ok(branchDetail);
        }

        [HttpGet("GetMovieByBranchId/{id}")]

        public async Task<IActionResult> GetMovieByBranch([FromRoute] int id)
        {

            if(id == null)
            {
                return NotFound();
            }

            var movies = await _service.GetMoviesByBranchId(id);


            return Ok(movies);
        }
    }
}

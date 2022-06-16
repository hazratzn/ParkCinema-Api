using System.Threading.Tasks;
using Business.Abstract;
using Business.Dto.Movies;
using Microsoft.AspNetCore.Mvc;

namespace Park_Cinema.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _moviesService;

        public MoviesController(IMovieService movieService)
        {
            _moviesService = movieService;
        }

        [HttpGet("GetMovies")]
        public async Task<IActionResult> GetMovies([FromHeader] string language)
        {
            var movies = await _moviesService.GetAllMoviesAsync(language);
            if(movies == null)
            {
                return NotFound();
            }
            return Ok(movies);
        }
        [HttpGet("GetMovieDetail/{id}")]
        public async Task<IActionResult> GetMovieDetail([FromRoute] int id, [FromHeader] string language)
        {
            var movieDetail = await _moviesService.GetMovieDetailByIdAsync(id, language);
            
            if(movieDetail == null)
            {
                return NotFound();
            }
            return Ok(movieDetail);
        }

        [HttpGet("GetFilteredMovies")]
        public async Task<IActionResult> GetFiltered([FromQuery] MovieFilterDto filter, [FromHeader] string language)
        {
            var data = await _moviesService.GetMoviesFiltered(filter, language);


            return Ok(data);

        }
       [HttpGet("GetMoviesByFormat")]
       public async Task<IActionResult> GetMoviesByFilter(string format, string language)
        {
            var movieData = await _moviesService.GetMovieByFormat(format, language);
            return Ok(movieData);
        }
    }
}

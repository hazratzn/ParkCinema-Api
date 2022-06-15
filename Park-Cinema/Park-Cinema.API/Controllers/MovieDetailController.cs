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
    public class MovieDetailController : ControllerBase
    {
        private readonly IMovieDetailService _movieDetailService;
        public MovieDetailController(IMovieDetailService movieDetailService)
        {
            _movieDetailService = movieDetailService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovieDetail(int id)
        {
            var movieDetail = await _movieDetailService.GetMovieDetailByIdAsync(id);
            return Ok(movieDetail);
        }
    }
}

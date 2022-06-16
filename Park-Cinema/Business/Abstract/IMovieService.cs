using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dto.Movies;
using Core.Repository;
using Entity.Dto;
using Entity.Entities;

namespace Business.Abstract
{
    public interface IMovieService : IRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<List<MovieDto>> GetAllMoviesAsync(string language);
        Task<List<Movie>> GetAllMoviesByLanguageCodeAsync(string language);
        Task<MovieDetailDto> GetMovieDetailByIdAsync(int id, string language);
        Task<List<MovieDto>> GetMoviesFiltered(MovieFilterDto filter, string language);
        Task<List<MovieDto>> GetMovieByFormat(string filter, string language);
    }
}

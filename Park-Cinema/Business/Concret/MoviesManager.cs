using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Business.Dto.Movies;
using Core.Repository.EFRepository;
using DataAccess.Abstract;
using DataAccess.Concret;
using Entity.Dto;
using Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business.Concret
{
    public class MoviesManager : EFRepositoryBase<Movie, AppDbContext>, IMovieService 
    {
        private readonly IMovieDal _moviesDal;
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public MoviesManager(IMovieDal moviesDal, AppDbContext context, IMapper mapper) : base(context)
        {
            _moviesDal = moviesDal;
            _context = context;
            _mapper = mapper;
        }

        public Task<Movie> GetMovieByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MovieDto>> GetAllMoviesAsync(string language)
        {
            var dbLanguage = await _context.Languages.FirstOrDefaultAsync(l => l.Name.ToLower() == language.ToLower());

            var languageId = dbLanguage.Id;
            
            var movieList = await _context.Movies
                .Include(m => m.Languages.FirstOrDefault(l => l.LanguageId == languageId))
                .ToListAsync();
            return _mapper.Map<List<MovieDto>>(movieList);
        }

        public async Task<MovieDetailDto> GetMovieDetailByIdAsync(int id, string language)
        {
            var dbLanguage = await _context.Languages.FirstOrDefaultAsync(l => l.Name.ToLower() == language.ToLower());

            var languageId = dbLanguage.Id;

            var movieDetail = await _context.Movies
                .Include(m => m.Languages.FirstOrDefault(l => l.LanguageId == languageId))
                .FirstOrDefaultAsync(x => x.Id == id);
            
            return _mapper.Map<MovieDetailDto>(movieDetail); 
        }

        public async Task<List<MovieDto>> GetMoviesFiltered(MovieFilterDto filter, string language)
        {
            var dbLanguage = await _context.Languages.FirstOrDefaultAsync(l => l.Name.ToLower() == language.ToLower());

            var languageId = dbLanguage.Id;
            
            var filteredMovies = await _context.Sessions
                .Include(s => s.Movie)
                .Include(s => s.Hall)
                .Where(m => (filter.Format == null || m.Movie.Formats.Contains(filter.Format)) &&
                            (filter.BranchId == null ||
                             m.Movie.Sessions.Any(s => s.Hall.BranchId == filter.BranchId)) &&
                            (filter.Language == null ||
                             m.Movie.Languages.FirstOrDefault().Languages.ToLower()
                                 .Contains(filter.Language.ToLower())))
                .Select(s => s.Movie).Distinct()
                .ToListAsync();


            return _mapper.Map<List<MovieDto>>(filteredMovies);
        }


        public async Task<List<MovieDto>> GetMovieByFormat(string filter, string language)
        {
            var dbLanguage = await _context.Languages.FirstOrDefaultAsync(l => l.Name.ToLower() == language.ToLower());

            var languageId = dbLanguage.Id;

            var formatMovies = await _context.Sessions
                .Include(s => s.Movie)
                .ThenInclude(s => s.Languages.FirstOrDefault(l => l.LanguageId == languageId))
                .Where(m => m.Movie.Formats.Contains(filter))
                .Select(x => x.Movie)
                .ToListAsync();
            return _mapper.Map<List<MovieDto>>(formatMovies);
        }

        public Task<List<Movie>> GetAllMoviesByLanguageCodeAsync(string languageCode)
        {
            throw new NotImplementedException();
        }
    }
}

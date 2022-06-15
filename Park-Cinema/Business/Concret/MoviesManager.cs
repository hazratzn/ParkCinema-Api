using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concret
{
    public class MoviesManager : IMovieService
    {
        private readonly IMovieDal _moviesDal;
        public MoviesManager(IMovieDal moviesDal)
        {
            _moviesDal = moviesDal;
        }

        public Task<bool> AddAsync(Movie entity)
        {
            throw new NotImplementedException();
        }

        public Task<object> AddReturnEntityAsync(Movie entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Movie entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Movie>> GetAllAsync(Expression<Func<Movie, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Movie>> GetAllMoviesAsync()
        {
            return await _moviesDal.GetAllAsync();
        }
        
        public Task<List<Movie>> GetAllMoviesAsync(string languageCode)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> GetAsync(Expression<Func<Movie, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> GetMovieByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Movie entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateWithEntryAsync(Movie entity, params object[] propertyNames)
        {
            throw new NotImplementedException();
        }
    }
}

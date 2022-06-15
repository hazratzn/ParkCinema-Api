using Core.Repository.EFRepository;
using DataAccess.Abstract;
using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concret
{
    public class EFMovieDal: EFRepositoryBase<Movie, AppDbContext>,IMovieDal
    {
        public EFMovieDal(AppDbContext dbContext) : base(dbContext)
        {

        }
        public async Task<bool> GetMovieAsync(Expression<Func<Movie, bool>> expression)
        {
            return await Context.Movies.AnyAsync(expression);
        }

        public Task<List<Movie>> GetMoviesAsync(string languageCode)
        {
            throw new NotImplementedException();
        }
    }
}

using System.Threading.Tasks;
using Core.Repository.EFRepository;
using DataAccess.Abstract;
using Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concret
{
    public class EFMovieDetailDal : EFRepositoryBase<Movie,AppDbContext>,IMovieDetailDal
    {

        public EFMovieDetailDal(AppDbContext dbContext) :base(dbContext)
        {

        }

        public async Task<Movie> GetMovieDetailAsync(int? id)
        {
            return await Context.Movies.SingleOrDefaultAsync(x=>x.Id==id);
        }

      
    }
}

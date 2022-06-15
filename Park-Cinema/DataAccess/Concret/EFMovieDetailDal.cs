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
    public class EFMovieDetailDal : EFRepositoryBase<MovieDetail,AppDbContext>,IMovieDetailDal
    {

        public EFMovieDetailDal(AppDbContext dbContext) :base(dbContext)
        {

        }

        public async Task<MovieDetail> GetMovieDetailAsync(int? id)
        {
            return await Context.MovieDetails.SingleOrDefaultAsync(x=>x.Id==id);
        }

      
    }
}

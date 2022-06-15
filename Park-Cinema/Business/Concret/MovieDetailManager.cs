using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concret
{
    public class MovieDetailManager : IMovieDetailService
    {
        private readonly IMovieDetailDal _movieDetailDal;
        public MovieDetailManager(IMovieDetailDal movieDetailDal)
        {
            _movieDetailDal = movieDetailDal;
        }
        public async Task<MovieDetail> GetMovieDetailByIdAsync(int id)
        {
            return await _movieDetailDal.GetMovieDetailAsync(id);
        }
    }
}

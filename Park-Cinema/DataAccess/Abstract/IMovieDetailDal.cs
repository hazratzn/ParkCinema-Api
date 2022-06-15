using Core.Repository;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IMovieDetailDal:IRepository<MovieDetail>
    {
        Task<MovieDetail> GetMovieDetailAsync(int? id);
        //Task<MovieDetail> GetMovieDetailAsync
    }
}

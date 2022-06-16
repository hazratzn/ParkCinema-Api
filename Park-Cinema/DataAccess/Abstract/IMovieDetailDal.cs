using System.Threading.Tasks;
using Core.Repository;
using Entity.Entities;

namespace DataAccess.Abstract
{
    public interface IMovieDetailDal:IRepository<Movie>
    {
        Task<Movie> GetMovieDetailAsync(int? id);
        //Task<MovieDetail> GetMovieDetailAsync
    }
}

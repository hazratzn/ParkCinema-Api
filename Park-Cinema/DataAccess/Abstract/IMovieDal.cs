using Core.Repository;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    
    public interface IMovieDal : IRepository<Movie>
    {
        Task<List<Movie>> GetMoviesAsync(string languageCode);
 
    }
}

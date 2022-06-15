using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRulesService
    {
        Task<Rules> GetRulesWithIdAsync(int id);
        Task<List<Rules>> GetAllRulesAsync();
        Task<List<Rules>> GetAllRulesAsync(string languageCode);

      
    }
}

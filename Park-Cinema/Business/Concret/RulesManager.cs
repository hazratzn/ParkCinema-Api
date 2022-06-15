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
    public class RulesManager:IRulesService
    {
        private readonly IRulesDal _rulesDal;
        public RulesManager(IRulesDal rulesDal)
        {
            _rulesDal = rulesDal;
        }

        public Task<bool> AddRulesAsync(Rules rules)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRulesAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Rules>> GetAllRulesAsync()
        {
            return await _rulesDal.GetAllAsync();
        }

        public Task<List<Rules>> GetAllRulesAsync(string languageCode)
        {
            throw new NotImplementedException();
        }

        public Task<Rules> GetRulesWithIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RulesAnyAsync(Expression<Func<Rules, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateRulesAsync(Rules rules)
        {
            throw new NotImplementedException();
        }
    }
}

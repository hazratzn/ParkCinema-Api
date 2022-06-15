using Core.Repository;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface INavbarDal:IRepository<Navbar>
    {
        Task<List<Navbar>> GetNavbarAsync(string languageCode);
        Task<bool> CheckNavbar();
    }
}

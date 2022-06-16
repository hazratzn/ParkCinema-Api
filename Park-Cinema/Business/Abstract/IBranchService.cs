using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dto.Branches;
using Core.Repository;
using Entity.Dto;
using Entity.Entities;

namespace Business.Abstract
{
    public interface IBranchService:IRepository<Branch>
    {
        Task<AboutUsDto> GetAboutUs(string language);
        Task<List<BranchDto>> GetBranches(string language);
        Task<BranchDetailDto> GetBranchDetailByIdAsync(int id);
        Task<List<MovieDto>> GetMoviesByBranchId(int id);

    }
}

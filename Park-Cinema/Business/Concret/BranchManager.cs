using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Business.Dto.Branches;
using Core.Repository.EFRepository;
using DataAccess.Concret;
using Entity.Dto;
using Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business.Concret
{
    public class BranchManager: EFRepositoryBase<Branch, AppDbContext>, IBranchService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public BranchManager(AppDbContext context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<BranchDetailDto> GetBranchDetailByIdAsync(int id)
        {
            var branchDetail = await _context.Branches.FirstOrDefaultAsync(x => x.Id == id);
            return _mapper.Map<BranchDetailDto>(branchDetail);
        }
       public async Task<List<MovieDto>> GetMoviesByBranchId(int id)
        {
            var movieBranch = await _context.Sessions
                .Include(x => x.Movie)
                .Include(x => x.Hall)
                .Where(m => m.Hall.BranchId == id).Select(x => x.Movie).Distinct().ToListAsync();
            return _mapper.Map<List<MovieDto>>(movieBranch);
       

        }

       public async Task<AboutUsDto> GetAboutUs(string language)
       {
           var dblanguage = await _context.Languages.FirstOrDefaultAsync(l => l.Name.ToLower() == language.ToLower());

           var languageId = dblanguage.Id;

           var query = await _context.AboutUs.Include(a => a.Language)
               .FirstOrDefaultAsync(a => a.LanguageId == languageId);

           return _mapper.Map<AboutUsDto>(query);
       }

       public async Task<List<BranchDto>> GetBranches(string language)
       {
           var dblanguage = await _context.Languages.FirstOrDefaultAsync(l => l.Name.ToLower() == language.ToLower());

           var languageId = dblanguage.Id;

           var query = await _context.Branches
               .Include(b => b.BranchLanguages.FirstOrDefault(b => b.LanguageId == languageId))
               .ToListAsync();

            return _mapper.Map<List<BranchDto>>(query);
        }

      
    }
}

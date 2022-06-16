using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Business.Dto.Sessions;
using Core.Repository.EFRepository;
using DataAccess.Concret;
using Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business.Concret
{
    public class SessionManager : EFRepositoryBase<Session, AppDbContext>, ISessionService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public SessionManager(AppDbContext context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<SessionDto>> GetSessionsByMovieId(int movieId)
        {
            var movie = await _context.Sessions
                .Include(s => s.SessionPrices)
                .Include(s => s.Hall)
                .ThenInclude(s => s.Branch)
                .Include(s => s.Movie)
                .Where(s => s.MovieId == movieId)
                .ToListAsync();

            return _mapper.Map<List<SessionDto>>(movie);

            
        }

        public async Task<List<SessionDto>> GetSessionByBranchId(int branchId, string language)
        {
            var dblanguage = await _context.Languages.FirstOrDefaultAsync(l => l.Name.ToLower() == language.ToLower());

            var languageId = dblanguage.Id;
            
            var branchSession = await _context.Sessions
                .Include(s => s.SessionPrices)
                .Include(s => s.Hall)
                .ThenInclude(s => s.Branch.BranchLanguages.FirstOrDefault(b => b.LanguageId == languageId))
                .Include(s => s.Movie)
                .Where(s => s.Hall.BranchId == branchId)
                .ToListAsync();
            
            return _mapper.Map<List<SessionDto>>(branchSession);
                
        }

        public async Task<List<SessionDto>> GetSessionByFormat(string format)
        {
            var formatSession = await _context.Sessions
                .Include(s => s.SessionPrices)
                .Include(s => s.Hall)
                .ThenInclude(s => s.Branch)
                .Include(s => s.Movie)
                .Where(s => s.Movie.Formats.Contains(format))
                .ToListAsync();
            
            return _mapper.Map<List<SessionDto>>(formatSession);
        }
    }
}

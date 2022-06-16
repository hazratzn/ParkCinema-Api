using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dto.Sessions;
using Core.Repository;
using Entity.Entities;

namespace Business.Abstract
{
    public interface ISessionService : IRepository<Session>
    {
        Task<List<SessionDto>> GetSessionsByMovieId(int movieId);
        Task<List<SessionDto>> GetSessionByBranchId(int branchId, string language);
        Task<List<SessionDto>> GetSessionByFormat(string format);
    }
}

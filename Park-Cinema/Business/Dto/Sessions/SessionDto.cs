using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Business.Abstract.Mapping;
using Business.Dto.Movies;
using Entity.Entities;

namespace Business.Dto.Sessions
{
    public class SessionDto : IMapFrom
    {
        public int Id { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public MovieDetailDto Movie { get; set; }
        public string BranchName { get; set; }
        public int BranchId { get; set; }
        public string HallName { get; set; } 
        public IEnumerable<string> Times { get; set; }
        public ICollection<SessionPriceDto> SessionPrices { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Session, SessionDto>()
                .ForMember(s => s.HallName,
                    d => d.MapFrom(src => src.Hall.Name))
                .ForMember(s => s.Times,
                    d => d.MapFrom(src => src.Movie.GetDates()))
                .ForMember(s => s.BranchId,
                    d => d.MapFrom(src => src.Hall.Branch.Id))
                .ForMember(s => s.BranchName,
                    d => d.MapFrom(src => src.Hall.Branch.BranchLanguages.FirstOrDefault().Name));
        }   
    }
}

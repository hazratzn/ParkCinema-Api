using System.Linq;
using AutoMapper;
using Business.Abstract.Mapping;
using Entity.Entities;

namespace Business.Dto.Movies
{
    public class MovieFilterDto : IMapFrom
    {
        public string Format { get; set; }
        public int? BranchId { get; set; }
        public string Language { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Movie, MovieFilterDto>()
                .ForMember(d => d.Language,
                    src => src.MapFrom(s => s.Languages.FirstOrDefault().Name));
        }
    }
}
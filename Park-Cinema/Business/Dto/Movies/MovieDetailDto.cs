using System.Linq;
using AutoMapper;
using Business.Abstract.Mapping;
using Entity.Entities;

namespace Business.Dto.Movies
{
    public class MovieDetailDto : IMapFrom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClaimerAge { get; set; }
        public string Image { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public string Country { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public string Trailer { get; set; }
        public string Actor { get; set; }
        public string VideoUrl { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string Director  { get; set; }
        public string Languages { get; set; }

        public string Formats { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Movie, MovieDetailDto>()
                .ForMember(d => d.Name, src => src.MapFrom(s => s.Languages.FirstOrDefault().Name))
                .ForMember(d => d.Languages, src => src.MapFrom(s => s.Languages.FirstOrDefault().Languages))
                .ForMember(d => d.Country, src => src.MapFrom(s => s.Languages.FirstOrDefault().Country))
                .ForMember(d => d.Genre, src => src.MapFrom(s => s.Languages.FirstOrDefault().Genre))
                .ForMember(d => d.Actor, src => src.MapFrom(s => s.Languages.FirstOrDefault().Actor));
        }
    }
}

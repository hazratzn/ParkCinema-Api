using System;
using System.Linq;
using AutoMapper;
using Business.Abstract.Mapping;
using Entity.Entities;

namespace Entity.Dto
{
    public class MovieDto : IMapFrom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int ClaimerAge { get; set; }
        public string Languages { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Formats { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Movie, MovieDto>()
                .ForMember(d => d.Name, src => src.MapFrom(s => s.Languages.FirstOrDefault().Name))
                .ForMember(d => d.Languages, src => src.MapFrom(s => s.Languages.FirstOrDefault().Languages));

        }
    }
}

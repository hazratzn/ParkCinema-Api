using AutoMapper;
using Business.Abstract.Mapping;
using Entity.Entities;

namespace Entity.Dto
{
    public class AboutUsDto : IMapFrom
    {
        public int Id { get; set; }
        public string Desription { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AboutUs, AboutUsDto>();
        }
    }
}

using AutoMapper;
using Business.Abstract.Mapping;
using Entity.Entities;
using Entity.Enums;

namespace Business.Dto.Sessions
{
    public class SessionPriceDto:IMapFrom
    {
        public int Id { get; set; }
        public SessionPriceType PriceType { get; set; }
        public decimal Price { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<SessionPrice, SessionPriceDto>();
        }
    }
}
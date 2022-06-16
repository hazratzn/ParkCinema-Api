using System.Collections.Generic;
using AutoMapper;
using Business.Abstract.Mapping;
using Entity.Entities;
using Entity.Enums;

namespace Business.Dto.Sales
{
    public class CreateTicketDto : IMapFrom
    {
        public int SessionPriceId { get; set; }
        public SessionPriceType PriceType { get; set; }
        public IList<int> SeatIds { get; set; }
        public int SeatCount { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerNumber { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Ticket, CreateTicketDto>().ReverseMap();
        }
    }
}
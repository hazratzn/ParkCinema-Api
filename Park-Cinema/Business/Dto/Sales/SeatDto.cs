using AutoMapper;
using Business.Abstract.Mapping;
using Entity.Entities;

namespace Business.Dto.Sales
{
    public class SeatDto : IMapFrom
    {
        public int Id { get; set; }
        public bool IsBusy { get; set; }
        public bool IsVip { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public int HallId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Seat, SeatDto>();
        }
    }
}
using AutoMapper;
using Business.Abstract.Mapping;
using Business.Dto.Branches;
using Entity.Dto;
using Entity.Entities;

namespace Business.Dto
{
    public class HallDto:IMapFrom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AcusticSystem { get; set; }
        public int SeatNumbers { get; set; }
        public string BarsChoose { get; set; }
        public string HallFormatD { get; set; }

        public string FilmProject { get; set; }
        public BranchDto Branch { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Hall, HallDto>();
        }
    }
}

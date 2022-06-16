using AutoMapper;
using Business.Abstract.Mapping;
using Entity.Entities;

namespace Business.Dto.Branches
{
    public class BranchDetailDto:IMapFrom
    {
        public int Id { get; set; }
        public int HallCount { get; set; }
        public string AcusticSystem { get; set; }
        public string HallFormatType { get; set; }
        public string BarsChoose { get; set; }
        public string Projects { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Branch, BranchDetailDto>();

        }
    }
}

using AutoMapper;
using Business.Abstract.Mapping;
using Entity.Entities;

namespace Business.Dto.Branches
{
    public class BranchDto : IMapFrom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }
        public string WorkingHours { get; set; }
        public string Image { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Branch, BranchDto>();
        }
    }
}
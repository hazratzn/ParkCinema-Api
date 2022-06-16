using AutoMapper;
using Business.Abstract;
using Business.Dto;
using Core.Repository.EFRepository;
using DataAccess.Concret;
using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concret
{
    public class HallManager : EFRepositoryBase<Hall, AppDbContext>, IHallService
    {
  
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public HallManager( AppDbContext context, IMapper mapper) : base(context)
        {
         
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<HallDto>> GetHallsByBranchId(int id)
        {
            var halls = await _context.Halls.Where(x => x.BranchId == id).ToListAsync();
            return _mapper.Map<List<HallDto>>(halls);


        }
    }
}

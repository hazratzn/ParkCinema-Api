using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Business.Dto.Sales;
using Core.Repository.EFRepository;
using DataAccess.Concret;
using Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace Business.Concret
{
    public class SaleManager : EFRepositoryBase<Movie, AppDbContext>, ISaleService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public SaleManager(AppDbContext context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ICollection<SeatDto>> GetSeatsOfHall(int sessionId)
        {
            var query = await _context.Seats
                .Where(s => s.SessionId == sessionId)
                .ToListAsync();

            return _mapper.Map<List<SeatDto>>(query);
        }

        public async Task CreateTicket(CreateTicketDto ticketDto)
        {
            var data = _mapper.Map<Ticket>(ticketDto);

            await _context.Tickets.AddAsync(data);
            await _context.SaveChangesAsync();

            foreach (var seatId in ticketDto.SeatIds)
            {
                var seat = await _context.Seats.FirstOrDefaultAsync(s => s.Id == seatId);
                seat.IsBusy = true;

                var newSeat = new TicketSeat
                {
                    SeatId = seatId,
                    TicketId = data.Id
                };

                await _context.TicketSeats.AddAsync(newSeat);
                await _context.SaveChangesAsync();
            }
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Dto.Sales;

namespace Business.Abstract
{
    public interface ISaleService
    {
        Task<ICollection<SeatDto>> GetSeatsOfHall(int sessionId);
        Task CreateTicket(CreateTicketDto ticketDto);
    }
}
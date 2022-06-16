using System.Collections.Generic;
using Entity.Enums;

namespace Entity.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public int SeatCount { get; set; }
        public SessionPriceType Type { get; set; }
        public int SessionId { get; set; }
        public Session Session { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerNumber { get; set; }
        public ICollection<TicketSeat> Seats { get; set; }
    }
}
using System.Threading.Tasks;
using Business.Abstract;
using Business.Dto.Sales;
using Microsoft.AspNetCore.Mvc;

namespace Park_Cinema.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly ISaleService _service;

        public SaleController(ISaleService service)
        {
            _service = service;
        }

        [HttpGet("GetSeats/{sessionId}")]
        public async Task<IActionResult> GetSeats([FromRoute] int sessionId)
        {
            var data = await _service.GetSeatsOfHall(sessionId);
            if (data == null)
            {
                return NotFound();
            }

            return Ok(data);
        }

        [HttpPost("BuyTicket")]
        public async Task<IActionResult> BuyTicket([FromBody] CreateTicketDto ticketDto)
        {
            await _service.CreateTicket(ticketDto);

            return Ok();
        }
    }
}
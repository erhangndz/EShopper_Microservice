using EShopper.SignalR.DataAccess.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShopper.SignalR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveriesController : ControllerBase
    {
        private readonly SignalRContext _context;

        public DeliveriesController(SignalRContext context)
        {
            _context = context;
        }

        [HttpGet("totalDeliveryCount")]
        public IActionResult TotalDeliveryCount()
        {
            var value = _context.Deliveries.Count();
            return Ok(value);
        }

        [HttpGet("TotalDeliveryCountByStatusYolda")]
        public IActionResult TotalDeliveryCountByStatusYolda()
        {
            var value = _context.Deliveries.Count(x => x.Status == "Yolda");
            return Ok(value);
        }

        [HttpGet("TotalDeliveryCountByStatusHazirlaniyor")]

        public IActionResult TotalDeliveryCountByStatusHazirlaniyor()
        {
            var value = _context.Deliveries.Count(x => x.Status == "Hazirlaniyor");
            return Ok(value);
        }

    }
}

using EShopper.SignalR.DataAccess.Context;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace EShopper.SignalR.Hubs
{
    public class SignalRHub: Hub
    {
        private readonly SignalRContext _context;

        public SignalRHub(SignalRContext context)
        {
            _context = context;
        }

        public async Task TotalDeliveryCount()
        {
            var value = await _context.Deliveries.CountAsync();

            await Clients.All.SendAsync("ReceiveTotalDeliveryCount", value);
        }


        public async Task TotalDeliveryCountByStatusYolda()
        {
            var value = _context.Deliveries.Count(x => x.Status == "Yolda");
            await Clients.All.SendAsync("ReceiveTotalDeliveryCountByStatusYolda", value);
        }

        public async Task TotalDeliveryCountByStatusHazirlaniyor()
        {
            var value = _context.Deliveries.Count(x => x.Status == "Hazirlaniyor");
            await Clients.All.SendAsync("ReceiveTotalDeliveryCountByStatusHazirlaniyor", value);
        }

    }
}

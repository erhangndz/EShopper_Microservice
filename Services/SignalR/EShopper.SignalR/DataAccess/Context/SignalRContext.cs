using EShopper.SignalR.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace EShopper.SignalR.DataAccess.Context
{
    public class SignalRContext: DbContext
    {

        public SignalRContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Delivery> Deliveries { get; set; }
    }
}

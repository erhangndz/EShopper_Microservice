using EShopper.Order.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.Order.DataAccessLayer.Context
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Ordering> Orderings { get; set; }
    }
}

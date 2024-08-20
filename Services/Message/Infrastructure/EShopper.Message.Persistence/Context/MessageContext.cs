using EShopper.Message.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.Message.Persistence.Context
{
    public class MessageContext : DbContext
    {

        public MessageContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<UserMessage> UserMessages { get; set; }


    }
}

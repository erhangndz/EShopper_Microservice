using EShopper.Order.DataAccessLayer.Abstract;
using EShopper.Order.DataAccessLayer.Context;
using EShopper.Order.DataAccessLayer.Repositories;
using EShopper.Order.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.Order.DataAccessLayer.Concrete
{
    public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(OrderContext context) : base(context)
        {
        }
    }
}

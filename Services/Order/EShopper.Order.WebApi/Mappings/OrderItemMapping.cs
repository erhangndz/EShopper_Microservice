using AutoMapper;
using EShopper.Order.DtoLayer.Dtos.OrderItemDtos;
using EShopper.Order.EntityLayer.Entities;

namespace EShopper.Order.WebApi.Mappings
{
    public class OrderItemMapping: Profile
    {
        public OrderItemMapping()
        {
            CreateMap<OrderItem, ResultOrderItemDto>().ReverseMap();
            CreateMap<OrderItem, CreateOrderItemDto>().ReverseMap();
            CreateMap<OrderItem, UpdateOrderItemDto>().ReverseMap();
        }
    }
}

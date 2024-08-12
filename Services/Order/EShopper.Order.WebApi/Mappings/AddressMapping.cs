using AutoMapper;
using EShopper.Order.DtoLayer.Dtos.AddressDtos;
using EShopper.Order.EntityLayer.Entities;

namespace EShopper.Order.WebApi.Mappings
{
    public class AddressMapping: Profile
    {
        public AddressMapping()
        {
            CreateMap<Address, ResultAddressDto>().ReverseMap();
            CreateMap<Address, CreateAddressDto>().ReverseMap();
            CreateMap<Address, UpdateAddressDto>().ReverseMap();
        }
    }
}

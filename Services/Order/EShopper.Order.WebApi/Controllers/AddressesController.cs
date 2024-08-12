using AutoMapper;
using EShopper.Order.BusinessLayer.Abstract;
using EShopper.Order.DtoLayer.Dtos.AddressDtos;
using EShopper.Order.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShopper.Order.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly IAddressService _addressService;
        private readonly IMapper _mapper;

        public AddressesController(IAddressService addressService, IMapper mapper)
        {
            _addressService = addressService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var values = _addressService.TGetList();
            var mappedValues = _mapper.Map<List<ResultAddressDto>>(values);
            return Ok(mappedValues);
        }

        [HttpPost]
        public IActionResult Create(CreateAddressDto createAddressDto)
        {
            var values = _mapper.Map<Address>(createAddressDto);
            _addressService.TCreate(values);
            return Ok("Adres başarıyla oluşturuldu");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var value = _addressService.TGetById(id);
            var mappedValue = _mapper.Map<ResultAddressDto>(value);
            return Ok(mappedValue);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _addressService.TDelete(id);
            return Ok("Adres başarıyla silindi");
        }

        [HttpPut]
        public IActionResult Update(UpdateAddressDto updateAddressDto)
        {
            var values = _mapper.Map<Address>(updateAddressDto);
            _addressService.TUpdate(values);
            return Ok("Adres başarıyla güncellendi");
        }
    }
}

using EShopper.Discount.Dtos;
using EShopper.Discount.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShopper.Discount.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CouponsController : ControllerBase
    {
        private readonly ICouponService _couponService;

        public CouponsController(ICouponService couponService)
        {
            _couponService = couponService;
        }

        [HttpGet]
        public IActionResult GetAllCoupons()
        {
            var values = _couponService.GetAllCoupons();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetCouponById(int id)
        {
            var value = _couponService.GetCouponById(id);
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateCoupon(CreateCouponDto createCouponDto)
        {
            _couponService.CreateCoupon(createCouponDto);
            return Ok("Kupon oluşturuldu");
        }

        [HttpPut]
        public IActionResult UpdateCoupon(UpdateCouponDto updateCouponDto)
        {
            _couponService.UpdateCoupon(updateCouponDto);
            return Ok("Kupon Güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCoupon(int id)
        {
            _couponService.DeleteCoupon(id);
            return Ok("Kupon Silindi");
        }


    }
}

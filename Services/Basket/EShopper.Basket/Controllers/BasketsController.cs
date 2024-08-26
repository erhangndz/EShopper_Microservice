using EShopper.Basket.Dtos;
using EShopper.Basket.Services;
using EShopper.Basket.Services.IdentityServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShopper.Basket.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IBasketService _basketService;
        private readonly IIdentityService _identityService;

        public BasketsController(IBasketService basketService, IIdentityService identityService)
        {
            _basketService = basketService;
            _identityService = identityService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBasket()
        {

            var basket = await _basketService.GetBasketAsync(_identityService.GetUserId);
            if (basket == null)
            {
                return BadRequest("Sepet bulunamadı");
            }
            return Ok(basket);
        }

        [HttpPost]
        public async Task<IActionResult> SaveOrUpdateBasket(TotalBasketDto totalBasketDto)
        {
            totalBasketDto.UserId = _identityService.GetUserId;
            await _basketService.SaveBasketAsync(totalBasketDto);
            return Ok("Sepet başarıyla güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBasket()
        {
            await _basketService.DeleteBasketAsync(_identityService.GetUserId);
            return Ok("Sepet başarıyla silindi");
        }


    }
}

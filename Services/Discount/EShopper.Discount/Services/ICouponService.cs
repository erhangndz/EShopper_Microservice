using EShopper.Discount.Dtos;
using EShopper.Discount.Entities;

namespace EShopper.Discount.Services
{
    public interface ICouponService
    {
        List<ResultCouponDto> GetAllCoupons();
        GetCouponByIdDto GetCouponById(int id);
        void CreateCoupon(CreateCouponDto createCouponDto);
        void UpdateCoupon(UpdateCouponDto updateCouponDto);
        void DeleteCoupon(int id);  

    }
}

using EShopper.Discount.Context;
using EShopper.Discount.Dtos;
using EShopper.Discount.Entities;

namespace EShopper.Discount.Services
{
    public class CouponService : ICouponService
    {
        private readonly DiscountContext _context;

        public CouponService(DiscountContext context)
        {
            _context = context;
        }

        public void CreateCoupon(CreateCouponDto createCouponDto)
        {
            var coupon = new Coupon
            {
                DiscountCode = createCouponDto.DiscountCode,
                DiscountRate = createCouponDto.DiscountRate,
                ExpiresIn = createCouponDto.ExpiresIn,
                IsActive = createCouponDto.IsActive,
            };

            _context.Add(coupon);
            _context.SaveChanges();
        }

        public void DeleteCoupon(int id)
        {
            var value = _context.Coupons.Find(id);
            _context.Coupons.Remove(value);
            _context.SaveChanges();
        }

        public List<ResultCouponDto> GetAllCoupons()
        {
            var values = _context.Coupons.ToList();

            return (from x in values
                    select new ResultCouponDto
                    {
                        CouponId = x.CouponId,
                        DiscountCode = x.DiscountCode,
                        DiscountRate = x.DiscountRate,
                        ExpiresIn = x.ExpiresIn,
                        IsActive = x.IsActive
                    }).ToList();
        }

        public GetCouponByIdDto GetCouponById(int id)
        {
            var value = _context.Coupons.Find(id);

            return new GetCouponByIdDto
            {
                CouponId = value.CouponId,
                DiscountCode = value.DiscountCode,
                DiscountRate = value.DiscountRate,
                ExpiresIn = value.ExpiresIn,
                IsActive = value.IsActive
            };
        }

        public void UpdateCoupon(UpdateCouponDto updateCouponDto)
        {
            var coupon = new Coupon
            {
                CouponId = updateCouponDto.CouponId,
                DiscountCode = updateCouponDto.DiscountCode,
                DiscountRate = updateCouponDto.DiscountRate,
                IsActive = updateCouponDto.IsActive,
                ExpiresIn = updateCouponDto.ExpiresIn

            };

            _context.Update(coupon);
            _context.SaveChanges();
        }
    }
}

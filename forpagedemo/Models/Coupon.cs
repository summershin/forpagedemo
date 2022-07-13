using System;
using System.Collections.Generic;

#nullable disable

namespace forpagedemo.Models
{
    public partial class Coupon
    {
        public int CouponId { get; set; }
        public int? ProductIdI { get; set; }
        public int? ProductIdIi { get; set; }
        public decimal? Discount { get; set; }
    }
}

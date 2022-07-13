using System;
using System.Collections.Generic;

#nullable disable

namespace forpagedemo.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? PayTypeId { get; set; }
        public int? ShipperId { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int? StatusId { get; set; }
        public decimal? TotalPrice { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Payment PayType { get; set; }
        public virtual Shipper Shipper { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

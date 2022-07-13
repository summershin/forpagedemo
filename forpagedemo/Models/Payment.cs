using System;
using System.Collections.Generic;

#nullable disable

namespace forpagedemo.Models
{
    public partial class Payment
    {
        public Payment()
        {
            Orders = new HashSet<Order>();
        }

        public int PayTypeId { get; set; }
        public string PayType { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}

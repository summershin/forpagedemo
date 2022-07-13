using System;
using System.Collections.Generic;

#nullable disable

namespace forpagedemo.Models
{
    public partial class TicketType
    {
        public TicketType()
        {
            OrderDetails = new HashSet<OrderDetail>();
            Temps = new HashSet<Temp>();
            TicketAndProducts = new HashSet<TicketAndProduct>();
        }

        public int TicketId { get; set; }
        public string TicketName { get; set; }
        public int? SubCategoryId { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Temp> Temps { get; set; }
        public virtual ICollection<TicketAndProduct> TicketAndProducts { get; set; }
    }
}

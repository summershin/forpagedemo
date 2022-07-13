using System;
using System.Collections.Generic;

#nullable disable

namespace forpagedemo.Models
{
    public partial class TicketAndProduct
    {
        public int TicketAndProductId { get; set; }
        public int? TicketId { get; set; }
        public int? ProductId { get; set; }
        public decimal? Price { get; set; }

        public virtual Product Product { get; set; }
        public virtual TicketType Ticket { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace forpagedemo.Models
{
    public partial class Temp
    {
        public int TempId { get; set; }
        public int ProductId { get; set; }
        public int? CustomerId { get; set; }
        public int? SubCategoryId { get; set; }
        public int? TicketId { get; set; }
        public int? Quantity { get; set; }
        public decimal? TotalPrice { get; set; }
        public string Seats { get; set; }
        public string TempOrder { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual TicketType Ticket { get; set; }
    }
}

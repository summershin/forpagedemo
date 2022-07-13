using System;
using System.Collections.Generic;

#nullable disable

namespace forpagedemo.Models
{
    public partial class Seat
    {
        public int SeatId { get; set; }
        public int ProductId { get; set; }
        public string SeatName { get; set; }
        public int? OrderDetailId { get; set; }

        public virtual Product Product { get; set; }
    }
}

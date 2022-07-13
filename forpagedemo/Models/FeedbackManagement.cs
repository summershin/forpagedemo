using System;
using System.Collections.Generic;

#nullable disable

namespace forpagedemo.Models
{
    public partial class FeedbackManagement
    {
        public int FeedbackId { get; set; }
        public int? CustomerId { get; set; }
        public string FeedbackContent { get; set; }
        public int? Ranking { get; set; }
        public int? ProductsId { get; set; }
        public DateTime? FeedbackDate { get; set; }
        public string ImagePath { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Products { get; set; }
    }
}

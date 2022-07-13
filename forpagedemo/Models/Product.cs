using System;
using System.Collections.Generic;

#nullable disable

namespace forpagedemo.Models
{
    public partial class Product
    {
        public Product()
        {
            Collections = new HashSet<Collection>();
            FeedbackManagements = new HashSet<FeedbackManagement>();
            OrderDetails = new HashSet<OrderDetail>();
            ProductsPhotos = new HashSet<ProductsPhoto>();
            Seats = new HashSet<Seat>();
            Temps = new HashSet<Temp>();
            TicketAndProducts = new HashSet<TicketAndProduct>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int? CityId { get; set; }
        public string Address { get; set; }
        public int? SupplierId { get; set; }
        public int? Quantity { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? SubCategoryId { get; set; }
        public string Introduction { get; set; }

        public virtual City City { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<Collection> Collections { get; set; }
        public virtual ICollection<FeedbackManagement> FeedbackManagements { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductsPhoto> ProductsPhotos { get; set; }
        public virtual ICollection<Seat> Seats { get; set; }
        public virtual ICollection<Temp> Temps { get; set; }
        public virtual ICollection<TicketAndProduct> TicketAndProducts { get; set; }
    }
}

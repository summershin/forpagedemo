using System;
using System.Collections.Generic;

#nullable disable

namespace forpagedemo.Models
{
    public partial class City
    {
        public City()
        {
            Products = new HashSet<Product>();
        }

        public int CityId { get; set; }
        public string City1 { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}

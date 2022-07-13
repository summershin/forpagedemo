using System;
using System.Collections.Generic;

#nullable disable

namespace forpagedemo.Models
{
    public partial class SubCategory
    {
        public SubCategory()
        {
            Products = new HashSet<Product>();
            Temps = new HashSet<Temp>();
        }

        public int SubCategoryId { get; set; }
        public int? CategoryId { get; set; }
        public string SubCategoryName { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Temp> Temps { get; set; }
    }
}

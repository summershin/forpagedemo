using System;
using System.Collections.Generic;

#nullable disable

namespace forpagedemo.Models
{
    public partial class ProductsPhoto
    {
        public int PhotoId { get; set; }
        public int? ProductId { get; set; }
        public byte[] Photo { get; set; }

        public virtual Product Product { get; set; }
    }
}

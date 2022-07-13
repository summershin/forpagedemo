using System;
using System.Collections.Generic;

#nullable disable

namespace forpagedemo.Models
{
    public partial class Collection
    {
        public int CollectionId { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }
        public int? CollectionTypeId { get; set; }

        public virtual CollectionType CollectionType { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}

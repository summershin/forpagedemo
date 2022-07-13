using System;
using System.Collections.Generic;

#nullable disable

namespace forpagedemo.Models
{
    public partial class CollectionType
    {
        public CollectionType()
        {
            Collections = new HashSet<Collection>();
        }

        public int CollectionTypeId { get; set; }
        public string CollectionType1 { get; set; }

        public virtual ICollection<Collection> Collections { get; set; }
    }
}

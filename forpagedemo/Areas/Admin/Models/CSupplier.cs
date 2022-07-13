using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjIGObackend.Models
{
    public class CSupplier
    {
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public string Address { get; set; }

        public bool SupplierState { get; set; }
    }
}

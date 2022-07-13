using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjShoppingCart.ViewModels
{
    public class ShoppingCartItem
    {
        public string Name { get; set; }
        public string BuyDay { get; set; }
        public int  Qty { get; set; }
        public int Price { get; set; }
    }
}

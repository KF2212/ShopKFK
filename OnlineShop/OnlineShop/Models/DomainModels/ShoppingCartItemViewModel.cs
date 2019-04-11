using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class ShoppingCartItemViewModel
    {
        public int Quantity { get; set; }
        public ProductViewModel Product { get; set; }




        //public int ShoppingCartItemId { get; set; }
        //public ProductViewModel Product { get; set; }
        //public int Amount { get; set; }
        //public string ShoppingCartId { get; set; }
    }
}

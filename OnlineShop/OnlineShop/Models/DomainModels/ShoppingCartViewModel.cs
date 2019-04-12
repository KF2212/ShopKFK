using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models.DomainModels
{
    public class ShoppingCartViewModel
    {
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItemViewModel> ShoppingCartItems { get; set; }
    }
}

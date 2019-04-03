using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.ViewComponents
{
    public class SuggestedProductsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<ProductViewModel> suggestedProductsList = new List<ProductViewModel>() { Program.Products[0], Program.Products[1], Program.Products[2] };
            return View("/Views/Product/SuggestedProducts.cshtml", suggestedProductsList);
        }
    }
}

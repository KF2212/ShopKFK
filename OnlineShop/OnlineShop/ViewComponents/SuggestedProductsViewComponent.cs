using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Helpers;
using OnlineShop.Models;
using OnlineShop.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.ViewComponents
{
    public class SuggestedProductsViewComponent : ViewComponent
    {
        private readonly OnlineShopContext _context;

        public SuggestedProductsViewComponent(OnlineShopContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            List<ProductViewModel> suggestedProductsList = _context.ProductModel.Select(x => ViewModelFactory.MapProductToViewModel(x)).ToList();
            //new List<ProductViewModel>() { Program.Products[0], Program.Products[1], Program.Products[2] };
            return View("/Views/Product/SuggestedProducts.cshtml", suggestedProductsList);
        }
    }
}

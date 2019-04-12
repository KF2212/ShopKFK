using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Helpers;
using OnlineShop.Models;
using OnlineShop.Models.DomainModels;

namespace OnlineShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly OnlineShopContext _context;
        public ProductController(OnlineShopContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Product(int id)
        {
            ProductViewModel viewModel = ViewModelFactory.MapProductToViewModel(_context.ProductModel.FirstOrDefault(x => x.Id == id));
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddProduct(ProductViewModel viewModel)
        {
            return RedirectToAction("Buy", "ShoppingCart", new { id = viewModel.Id });
        }

        public async Task<IActionResult> Show(string genre)
        {
            List<ProductModel> products;
            if (!string.IsNullOrEmpty(genre))
            {
                products = await _context.ProductModel.Where(m => string.Equals(m.Name, genre, StringComparison.InvariantCultureIgnoreCase)).ToListAsync();
            }
            else
            {
                products = await _context.ProductModel.ToListAsync();
            }
            if (products == null)
            {
                return NotFound();
            }
            ViewData["Genre"] = genre;
            return View(products);
        }
    }
}
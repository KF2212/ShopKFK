using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;


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

    /*  [Route("")]
        [Route("index")]
        [Route("~/")]*/
        [HttpGet]
        public IActionResult Product(int id)
        {
            ProductViewModel viewModel = Program.Products.FirstOrDefault(x => x.Id == id);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddProduct(ProductViewModel viewModel)
        {
            return RedirectToAction("Buy", "ShoppingCart", new { id = viewModel.Id });
        }

        public async Task<IActionResult> Show(string genre)
        {
            var products = await _context.ProductModel.Where(m => m.Name == genre).ToListAsync();

            if (products == null || genre == null)
            {
                return NotFound();
            }
            ViewData["Genre"] = genre;
            return View(products);
        }
    }
}
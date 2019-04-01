using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class ProductController : Controller
    {
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
    }
}
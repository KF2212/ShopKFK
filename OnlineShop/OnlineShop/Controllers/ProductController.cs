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

        [HttpGet]
        public IActionResult Product(int id)
        {
            //Add logic to fetch data from DB
            ProductViewModel viewModel = new ProductViewModel
            {
                Name = "Jeansy",
                Size = Helpers.Sizes.M,
                Description = "Lorem ipsum",
                Id = id,
                Color = Helpers.Colors.Black
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddProduct(ProductViewModel viewModel)
        {
            return Json(new { Success = true });
        }
    }
}
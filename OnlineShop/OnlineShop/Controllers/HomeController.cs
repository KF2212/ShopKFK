using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("MainPage")]
        public IActionResult MainPage()
        {
            return View();
        }

        public IActionResult ContactForm()
        {
            return View();
        }
    }
}
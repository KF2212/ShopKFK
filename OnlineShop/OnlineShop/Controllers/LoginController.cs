using DAL.ViewModels;
using Microsoft.AspNetCore.Identity.UI.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
        [Route("/")]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserViewModel userViewModel)
        {
            //TODO: Validate userViewModel against database
            bool isValid = true;
            if(isValid)
            {
                return RedirectToAction("MainPage", "Home");
            }
            return View();
        }
        
        [Route("errorMessage")]
        public BadRequestResult ErrorMessage()
        {
            return BadRequest();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
        //
    }
}
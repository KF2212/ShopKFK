using DAL.ViewModels;
using Microsoft.AspNetCore.Identity.UI.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace OnlineShop.Controllers
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
        [Route("/")]
        public IActionResult Login()
        {
            return View();
        }
        [Route("Jeans")]
        public IActionResult Product()
        {
            return View();
        }
        [Route("MainPage")]
        public IActionResult MainPage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MainPage(UserViewModel userViewModel)
        {
            return View(userViewModel);
        }
        [Route("errorMessage")]
        public BadRequestResult ErrorMessage()
        {
            return BadRequest();
        }
       
    }
}
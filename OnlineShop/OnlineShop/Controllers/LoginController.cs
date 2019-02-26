using DAL.ViewModels;
using Microsoft.AspNetCore.Identity.UI.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

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
        //public ViewResult MainPage(UserViewModel user)
        //{
        //    //return PasswordValidator
        //}
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
        //[HttpPost]
        //public async Task<HttpResponseMessage> Foo()
        //{
        //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "naughty");
        //    response.Content = new StringContent("Naughty");

        //    return response;
        //}
    }
}
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace OnlineShop
{
    public class DetailController: Controller
    {
        private readonly DetailContext _details;

        public DetailController(DetailContext details)
        {
            _details = details;
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult SignUp()
        {
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(SignUp model)
        {
            if (ModelState.IsValid)
            {
                _details.signUp.Add(model);
                _details.SaveChanges();
                ModelState.Clear();

                ViewBag.Message = model.UserName + " " + "Sucess :)";

            }
            return View();
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult LogIn()
        {
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn(SignUp model,string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            var usr = _details.signUp.Where(u => u.EmailAddress == model.EmailAddress && u.Password == model.Password).FirstOrDefault();
            if (ModelState.IsValid&&usr!=null)
            {
                return RedirectToAction("LoggedIn");
            }
            else
            {
                return new BadRequestObjectResult(ModelState);
            }
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult validate(Validate model)
        //{
        //}

    }
}

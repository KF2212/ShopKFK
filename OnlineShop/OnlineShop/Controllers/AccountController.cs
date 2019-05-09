using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models.DomainModels;
using OnlineShop.Models.IdentityModels;

namespace OnlineShop.Controllers
{

    public class AccountController : Controller
    {
        private SignInManager<User> _signManager;
        private UserManager<User> _userManager;
        public AccountController(UserManager<User> userManager, SignInManager<User> signManager)
        {
            _userManager = userManager;
            _signManager = signManager;
        }
        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user = new User { UserName = model.Username };
                var result = await _userManager.CreateAsync(user, model.Password);
                //builder.Entity<IdentityUserRole<Guid>>().HasKey(p => new { p.UserId, p.RoleId });

                if (result.Succeeded)
                {
                    await _signManager.SignInAsync(user, false);
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signManager.SignOutAsync();
            return RedirectToAction("MainPage", "Account");
        }
        [HttpGet]
        public IActionResult Login(string returnUrl = "")
        {
            var model = new LoginViewModel { ReturnUrl = returnUrl };
            return View(model);
        }

        public IActionResult MainPage()
        {
            if (User.IsInRole("Admin"))
                return this.RedirectToAction("Index", "Admin");
            else if (User.IsInRole("Member"))
                return this.RedirectToAction("Manage", "Account");
            else
                return RedirectToAction("MainPage", "Home");
        }

        [Authorize]
        public IActionResult Manage()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {

            if (ModelState.IsValid)
            {
                var result = await _signManager.PasswordSignInAsync(model.Username,
                   model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {   //if (User.IsInRole("Admin"))
                        return this.RedirectToAction("MainPage", "Account");
                    }

                }
            }
            ModelState.AddModelError("", "Invalid login attempt");
            return View(model);
        }

        //private UserManager<User> _userManager;

        //        public EditUserController(UserManager<User> userManager)
        //        {
        //            _userManager = userManager;
        //        }
        //        // GET: Products/Edit/5
        //        public async Task<IActionResult> Edit(int?id)
        //        {
        //            if (id== null)
        //            {
        //                return NotFound();
        //            }

        //            var products = await _userManager.;
        //            if (products == null)
        //            {
        //                return NotFound();
        //            }
        //            return View(products);
        //        }

        //        // POST: Products/Edit/5
        //        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        public async Task<IActionResult> Edit([Bind(Exclude = null)] RegisterViewModel model)
        //        {
        //                if (ModelState.IsValid)
        //                {
        //                    AUser user = _userManager.FindByIdAsync(model.Id);

        //                    user = new Student
        //                    {
        //                        UserName = model.Name,
        //                        email= model.Surname,

        //                    };

        //                   _userManager.Update(user);
        //                }
        //        }
    }
}
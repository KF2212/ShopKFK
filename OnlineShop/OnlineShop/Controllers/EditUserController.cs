using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Models;

//namespace OnlineShop.Controllers
//{
//    public class EditUserController : Controller
//    {
//        private UserManager<User> _userManager;

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
//    }
//}

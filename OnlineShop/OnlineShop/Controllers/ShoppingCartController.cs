using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using OnlineShop.Helpers;
using Microsoft.AspNetCore.Authorization;

namespace OnlineShop.Controllers
{
    [Route("cart")]
    public class ShoppingCartController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Product.Price * item.Quantity);
            return View();
        }

        [Route("buy/{id}")]
        public IActionResult Buy(int id)
        {
            //TODO: Get poduct by ID from DB
            ProductViewModel productViewModel = Program.Products.FirstOrDefault(x => x.Id == id);

            List<ShoppingCartItem> cart = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart") ?? new List<ShoppingCartItem>();
            if(cart.Any(x=>x.Product.Id == id))
            {
                cart.First(x => x.Product.Id == id).Quantity++;
            }
            else
            {
                cart.Add(new ShoppingCartItem { Product = productViewModel, Quantity = 1 });
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }

        [Route("remove/{id}")]
        public IActionResult Remove(int id)
        {
            List<ShoppingCartItem> cart = SessionHelper.GetObjectFromJson<List<ShoppingCartItem>>(HttpContext.Session, "cart") ?? new List<ShoppingCartItem>();
            ShoppingCartItem item = cart.FirstOrDefault(x => x.Product.Id == id);
            if(item != null)
            {
                item.Quantity--;
                if(item.Quantity == 0)
                {
                    cart.RemoveAll(x => x.Product.Id == id);
                }
            }
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }
    }
}

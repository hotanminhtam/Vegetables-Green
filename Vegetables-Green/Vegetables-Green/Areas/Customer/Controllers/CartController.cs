using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vegetables_Green.Areas.Customer.Controllers
{
    public class CartController : Controller
    {
        // GET: Customer/Cart/ShoppingCart
        public ActionResult ShoppingCart()
        {
            return View();
        }

        // GET: Customer/Cart/Checkout
        public ActionResult CheckOut()
        {
            return View();
        }

        // GET: Customer/Cart/Order
        public ActionResult Order()
        {
            return View();
        }
    }
}
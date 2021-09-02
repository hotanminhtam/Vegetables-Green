using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vegetables_Green.Areas.Admin.Controllers
{
    public class PricesController : Controller
    {
        // GET: Admin/Prices/Fruits
        public ActionResult Fruits_Prices()
        {
            return View();
        }

        // GET: Admin/Prices/Vegetables
        public ActionResult Vegetables_Prices()
        {
            return View();
        }

        // GET: Admin/Prices/Meat
        public ActionResult Meat_Prices()
        {
            return View();
        }
    }
}
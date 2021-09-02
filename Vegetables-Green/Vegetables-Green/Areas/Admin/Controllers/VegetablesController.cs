using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vegetables_Green.Areas.Admin.Controllers
{
    public class VegetablesController : Controller
    {
        // GET: Admin/Vegetables/Vegetables
        public ActionResult Vegetables()
        {
            return View();
        }

        // GET: Admin/Vegetables/Fruits
        public ActionResult Fruits()
        {
            return View();
        }
    }
}
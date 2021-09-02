using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vegetables_Green.Areas.Admin.Controllers
{
    public class Fresh_FoodController : Controller
    {
        // GET: Admin/Fresh_Food/Meat
        public ActionResult Meat()
        {
            return View();
        }

        // GET: Admin/Fresh_Food/Fish
        public ActionResult Fish()
        {
            return View();
        }
    }
}
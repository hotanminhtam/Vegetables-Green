using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vegetables_Green.Areas.Admin.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Admin/Accounts/Admin
        public ActionResult Account_Admin()
        {
            return View();
        }

        // GET: Admin/Accounts/Customer
        public ActionResult Account_Customer()
        {
            return View();
        }
    }
}
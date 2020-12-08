using PaySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaySystem.Controllers
{
    public class BalanceController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Balance()
        {
            ViewBag.Message = "Your balance page.";

            var users = db.Users;
            ViewBag.Users = users;
            return View();
        }
    }
}
using Microsoft.AspNet.Identity;
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

        [HttpGet]
        public ActionResult Balance()
        {
            ViewBag.Message = "Your balance page.";

            var users = db.Users;
            ViewBag.Users = users;

            return View();
        }


        [HttpPost]
        public ViewResult Balance(BalanceModels balance)
        {
            var userPayer = db.Users
                .Where(c => c.BalanceNumber == balance.PayerBalanceNumber)
                .FirstOrDefault();
            if (userPayer.UserBalance - balance.ReceiverValue >= 0 || balance.ReceiverValue >= 0)
            {
                userPayer.UserBalance -= balance.ReceiverValue;

                var  userRecivier = db.Users
                    .Where(c => c.BalanceNumber == balance.ReceiverBalanceNumber)
                    .FirstOrDefault();
                userRecivier.UserBalance += balance.ReceiverValue;
            }
                

            db.SaveChanges();

            var users = db.Users;
            ViewBag.Users = users;
            return View("Balance");

        }

    }
}
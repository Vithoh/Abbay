﻿using AbayMVC.Models;
using AbayMVC.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AbayMVC.Controllers
{
    public class AccountController : Controller
    {

        // GET: Account
        public ActionResult Login()
        {

            return View();
        }

        public ActionResult Register()
        {

            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                string userName = Convert.ToString(model.UserName);
                string firstName = Convert.ToString(model.FirstName);
                string lastName = Convert.ToString(model.LastName);
                string email = Convert.ToString(model.Email);
                string password = Convert.ToString(model.Password);

                UserServiceReference.User user = new UserServiceReference.User()
                {
                    UserName = userName,
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    Password = password
                };

                Services.Instance.UserClient().CreateUser(user, out string message);


                return RedirectToAction("Index", "Home");
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }





        [HttpPost]
        public ActionResult Login(AccountViewModel avm)
        {
            AccountModel am = new AccountModel();
            Account ac;

            if ((string.IsNullOrEmpty(avm.Account.Username) || string.IsNullOrEmpty(avm.Account.Password)) || (ac = am.Login(avm.Account.Username, avm.Account.Password)) == null)
            {
                ViewBag.Error = "Account's Invalid";
                return View("Login");
            }
            SessionPersister.Token = ac.Token;

            return RedirectToAction("Index", "Home");
        }
        


    }
}
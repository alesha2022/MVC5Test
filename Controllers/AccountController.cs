﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login(string Username, string Password)
        {
            if (Username == "admin" && Password == "manager")
                return RedirectToAction("Dashboard", "Admin");
            else
                return RedirectToAction("InvalidLogin");
           
        }
        public ActionResult InvalidLogin(string Username, string Password)
        {
            return View();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilWebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Hello :)
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}

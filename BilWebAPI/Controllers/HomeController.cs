using System;
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

            DBEIDAL db = new DBEIDAL();

            db.SaveEventInfo(3, 88.999999, 88.999999, "BB 33 444");

            return View();
        }
    }
}

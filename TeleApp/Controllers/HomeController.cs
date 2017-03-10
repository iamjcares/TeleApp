using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeleApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to JohnnyCares Platform";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Plusonet is an IT industry";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You can  reach us on this email: email@email.com";

            return View();
        }
    }
}

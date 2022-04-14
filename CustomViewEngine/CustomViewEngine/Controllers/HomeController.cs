using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomViewEngine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Hello World";
            ViewData["CurrentTime"] = DateTime.Now.ToShortTimeString();
            return View("MyCustomData");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("MyCustomData");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View("MyCustomData");
        }
    }
}
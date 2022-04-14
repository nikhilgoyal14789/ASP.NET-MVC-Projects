using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomizingRazorViewEngine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string[] array = { "Nikhil", "Kumar", "Goyal" };
            return View(array);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
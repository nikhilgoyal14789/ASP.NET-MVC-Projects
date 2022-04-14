using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationsWithDataAnnotations.Models;

namespace ValidationsWithDataAnnotations.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        [HttpGet]
        public ActionResult SignUpPage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUpPage(UserDetails ud)
        {
            if(ModelState.IsValid)
                return Content("Hello");
            return View(ud);
        }
    }
}
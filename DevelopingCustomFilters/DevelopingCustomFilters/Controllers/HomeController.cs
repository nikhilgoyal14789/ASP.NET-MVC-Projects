using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevelopingCustomFilters.Controllers
{
    [CustomActionFilter]
    //Controller Level Approach
    public class HomeController : Controller
    {
        //[CustomActionFilter(Order =1)]
        //[NewCustomActionFilter(Order =2)]
        //Action Level Approach
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
    }
}
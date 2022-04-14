using CustomModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomModelBinding.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //public ActionResult Index(Customer cs)
        public ActionResult Index([ModelBinder(typeof(CustomCustomerBinder))]Customer cs)
        {
            string message = "";
            message += cs.CustomerId + " - " + cs.Present.PresentCityName + " - "+cs.Present.PresentStateName +" - "+ cs.Present.PresentCountryName;
            return Content(message);
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
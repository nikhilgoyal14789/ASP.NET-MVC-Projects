using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleWebApplication.Controllers
{
    public class ViewBagViewDataController : Controller
    {
        // GET: ViewBagViewData
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Introduction()
        {
            ViewBag.Name = "Nikhil Goyal";
            return View();
        }

        [HttpGet]
        public ActionResult StateManagementDemo()
        {
            ViewData["Ecode"] = 100;
            ViewData["Ename"] = "Nikhil Goyal";

            ViewBag.Eaddress = "Agra";

            TempData.Add("Ecountry", "India");
            TempData.Keep();
            return View();
        }

        [HttpPost]
        public ActionResult StateManagementDemo(FormCollection forms)
        {
            TempData.Keep();
            return View();
        }

    }
}
using SampleWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleWebApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            ViewBag.Greeting = "Hello World Hello MVC";

            Authors au = new Authors();
            au.AName = "Nikhil Goyal";
            au.Address = " Kiraoli Agra";

            return View(au);
        }

        public ActionResult Contact(string phno= "+91 123456789")
        {
            ViewBag.Contact = phno;
            return View();
        }

        public ActionResult GotoUrl(string url="https://www.google.com")
        {
            return Redirect(url);
        }
    }
}
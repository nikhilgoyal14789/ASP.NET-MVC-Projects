using SampleWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleWebApplication.Controllers
{
    public class ShowURLElementToController : Controller
    {
        // GET: ShowURLElementTo
        public ActionResult Index()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];
          
            var message = string.Format(" {0}:{1}:{2} ", controller, action, id);
            ViewBag.Message = message;
           
            return View();
        }

        public ViewResult Name(string Message="Goyal")
        {
            ViewBag.EnteredName = Message;
            return View();
        }

        public ContentResult Custom()
        {
            //return View("Name");
            return Content("<b><i>Hello Nikhil Goyal</i></b>");
        }

        public RedirectResult GotoURL()
        {
            return Redirect("https://www.google.com");
        }
        public RedirectResult GotoURL1()
        {
            return RedirectPermanent("https://www.google.com");
        }

        public RedirectToRouteResult RedirectAction()
        {
            return RedirectToAction("Name",new { Message = "I am coming from different action" });
        }

        public RedirectToRouteResult GotoRoute()
        {
            return RedirectToRoute("NewRoute1");
        }

        public FileResult ShowCSSFile()
        {
            return File(Server.MapPath("~/Controllers/HomeController.cs"), "text/cs");
        }

        public JsonResult ShowJsonResult()
        {
            Information inf = new Information()
            {
                Name = "Nikhil Goyal",
                Sec= 1,
                Age= 22
            };

            // using object initializer syntax for initialising the instance variables
            return Json(inf, JsonRequestBehavior.AllowGet);
        }

        public PartialViewResult ShowChildView()
        {
            return PartialView();
        }
        
        //http://localhost:56999/ShowURLElementTo/ShowCSSFile
    }
}
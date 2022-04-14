using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrossSiteRequestForgery.Controllers
{
    public class ScriptInjectionsController : Controller
    {
        // GET: ScriptInjections
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ScriptInjection()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public string ScriptInjection(string description)
        {
            return Server.HtmlEncode(description);  //printing the script as Plain Text
            //return description;   //executing the script if ValidateInput(false) is false
        }
    }
}
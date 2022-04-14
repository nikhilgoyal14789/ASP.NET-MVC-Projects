using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AJAXWithMVC.Controllers
{
    public class AJAXActionLinkController : Controller
    {
        // GET: AJAXActionLink
        public ActionResult Index()
        {
            return View();
        }

        public string GetCurrentDate()
        {
            System.Threading.Thread.Sleep(5000);
            return DateTime.Now.ToLongDateString();
        }

        public string ShowMessage(string firstName , string LastName)
        {
            return "Welcome Back " + firstName+" "+ LastName;
        }
    }
}
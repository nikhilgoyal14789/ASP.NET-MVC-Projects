using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrossSiteRequestForgery.Controllers
{
    public class LoginFormController : Controller
    {
        // GET: LoginForm
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult LoginCredentialForm()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginCredentialForm(FormCollection form)
        {
            string UserName = form["UserName"];
            string Password = form["Password"];

            if (UserName.Equals("Nikhil") && Password.Equals("Nikhil"))
            {
                ViewBag.Result = "Login Successfull";
                return View();
            }
            else
            {
                ViewBag.Result = "Login Unsuccessfull";
                return View();
            }
        }
    }
}
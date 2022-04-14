using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebPractiseSolution.Controllers
{
    //[CustomFilterModel]
    public class CustomFilterPractiseController : Controller
    {
        // GET: CustomFilterPractise
        //[CustomFilterModel]
        public ActionResult Index()
        {
            return View();
        }

        //[CustomFilterModel]
        public ActionResult FilterTest()
        {
            return View();
        }
    }

}
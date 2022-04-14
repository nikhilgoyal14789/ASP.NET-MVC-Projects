using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormSubmitTechniques.Controllers
{
    public class RetrievingDataWithFormElementNamesController : Controller
    {
        // GET: RetrievingDataWithFromElementNames
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string Name ,IEnumerable<string> CheckBox) // You can use List also inplace of IEnumerable
        {
            //string message = Request.Form.ToString();
            string message = "<b>Name is : </b>" + Name+"<br><b> Hobbies : </b><br>";

            foreach(string str in CheckBox)
            {
                message += str + "<br>";
            }
            return Content(message);
        }
    }
}
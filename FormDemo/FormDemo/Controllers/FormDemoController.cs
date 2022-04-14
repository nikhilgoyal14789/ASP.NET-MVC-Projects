using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormDemo.Controllers
{
    public class FormDemoController : Controller
    {
        // GET: FormDemo
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        //Working with HTML Helper using Razor Syntax
        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            string Product = collection["Product"];
            int Cost = Convert.ToInt32(collection["Cost"]);
            string Gender = collection["Gender"];
            string Hobbies=collection["Hobbies"];

            var HobbiesCount = -1;
            var HobbiesArray = Hobbies.Split(',');
            var HobbiesArrayLength = HobbiesArray.Length;
            if (HobbiesArrayLength == 3)
                HobbiesCount = 1;
            else if (HobbiesArrayLength == 4)
                HobbiesCount = 2;
            else
                HobbiesCount = 0;
            
            int StateValue=Convert.ToInt32(collection["State"]);

            string State;
            if (StateValue == 1)
                State = "No State Selected";
            else if (StateValue == 2)
                State = "Uttar Pradesh";
            else if (StateValue == 3)
                State = "Rajasthan";
            else
                State = "Madhya Pradesh";

            ViewBag.Product = Product;
            ViewBag.Cost = Cost;
            ViewBag.Gender = Gender;
            ViewBag.Hobbies = HobbiesCount;
            ViewBag.State = State;

            return View();
        }

        /*[HttpPost]
        //Approach 2
         
        public ActionResult Index(string empName, int empCode, string empAdd, string empPos)
        {
            ViewBag.empName = empName;
            ViewBag.empCode = empCode;
            ViewBag.empAdd = empAdd;
            ViewBag.empPos = empPos;

            return View();
        }

        [HttpPost]
        //Approach 3
        public ActionResult Index(FormCollection collection)
        {
            string empName = collection["empName"];
            int empCode=Convert.ToInt32(collection["empCode"]);
            string empAdd = collection["empAdd"];
            string empPos = collection["empPos"];

            ViewBag.empName = empName;
            ViewBag.empCode = empCode;
            ViewBag.empAdd = empAdd;
            ViewBag.empPos = empPos;

            return View();
        }
        [HttpPost]
        //Approach 1
        public ActionResult Information()
        {
            string empName = Request.Form["empName"];
            long empCode = Convert.ToInt64(Request.Form["empCode"]);
            string empAdd = Request.Form["empAdd"];
            string empPos = Request.Form["empPos"];

            ViewBag.empName = empName;
            ViewBag.empCode = empCode;
            ViewBag.empAdd = empAdd;
            ViewBag.empPos = empPos;

            return View("Index");
        }
        */
    }
}
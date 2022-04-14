
using FormSubmitTechniques.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormSubmitTechniques.Controllers
{
    public class ReceivingDatainFCAndCreateModelObjectController : Controller
    {
        // GET: ReceivingDatainFCAndCreateModelObject
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection fc)
        {
            string message = "";
            AddressDetail present = new AddressDetail();        //You can write any object name
            AddressDetail permanent = new AddressDetail();      //You can write any object name

            UpdateModel(present, "Present");    // It will throw an Exception if validation fails

            bool Result = TryUpdateModel(permanent, "Permanent");       //It will return false if validation fails & It doesn't throw any Exception

            message+=present.CityName + "->" + present.StateName + "->" + present.CountryName + "<br>" + permanent.CityName + "->" + permanent.StateName+ "->" +permanent.CountryName;
            message += "<br>" + Result;
            return Content(message);
        }
    }
}
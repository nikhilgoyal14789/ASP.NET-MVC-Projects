using FormSubmitTechniques.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormSubmitTechniques.Models
{
    public class ReceivingDataWithModelObjectController : Controller
    {
        // GET: ReceivingDataWithModelObject
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        //To Exclude some fields
        //public ActionResult Index([Bind(Exclude="PersonId")]PersonInfo person, HttpPostedFileBase photo)
        //To Include some fields only
        //public ActionResult Index([Bind(Include = "Address,PersonId")]PersonInfo person, HttpPostedFileBase photo)
        public ActionResult Index(PersonInfo person, HttpPostedFileBase photo)
        {
            string msg = person.PersonId + "->" + person.PersonName + "->" + person.Address.CityName + "->" + person.Address.StateName + "->" + person.Address.CountryName;

            //To save the photo to the Browser this below line is must
            //new { enctype="multipart/form-data"} inside Html.BeginForm() with 4th Parameter
            if (photo!=null)
            {
                string vpath = "~/Content/" + photo.FileName;
                string ppath = Server.MapPath(vpath);
                photo.SaveAs(ppath);
            }
            return Content(msg);
        }

        [HttpGet]
        public ActionResult GetAddress()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetAddress([Bind(Prefix="Present")]AddressDetail p, AddressDetail Permanent)
        {
            string presentAddress = p.CityName + " - " + p.StateName + " - " + p.CountryName;
            string permanentAddress = Permanent.CityName + " - " + Permanent.StateName + " - " + Permanent.CountryName;

            string completeAddress = presentAddress + "\n\n" + permanentAddress;
            return Content(completeAddress);
        }
    }
}
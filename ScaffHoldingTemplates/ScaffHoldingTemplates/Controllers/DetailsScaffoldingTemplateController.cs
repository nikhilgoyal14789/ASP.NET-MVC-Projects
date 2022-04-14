using ScaffHoldingTemplates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScaffHoldingTemplates.Controllers
{
    public class DetailsScaffoldingTemplateController : Controller
    {
        // GET: DetailsScaffoldingTemplate
        static readonly Products prod = new Products()
        {
            ProductName = "L. Laptop",
            ProductCost = 20000,
            ProductQuantity = 2,
            ProductTax = 20,
            ProductFinalPrice = 0,
            CategoryId = 3
        };
        public ActionResult Index()
        {
            return View(prod);
        }

        public ActionResult DisplayDetailedInformation()
        {
            return View(prod);
        }
    }
}
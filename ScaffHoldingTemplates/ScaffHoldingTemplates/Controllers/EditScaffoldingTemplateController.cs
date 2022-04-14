using ScaffHoldingTemplates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScaffHoldingTemplates.Controllers
{
    public class EditScaffoldingTemplateController : Controller
    {
        // GET: EditScaffoldingTemplate
        static readonly Products prod = new Products()
        {
            ProductName = "L. Laptop",
            ProductCost = 40000,
            ProductQuantity = 10,
            ProductTax = 20,
            ProductFinalPrice = 28000,
            CategoryId = 3
        };
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EditScaffoldingTemplate()
        {
            return View(prod);
        }
    }
}
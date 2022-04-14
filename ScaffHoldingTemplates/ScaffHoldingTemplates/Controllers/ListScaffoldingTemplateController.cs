using ScaffHoldingTemplates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScaffHoldingTemplates.Controllers
{
    public class ListScaffoldingTemplateController : Controller
    {
        // GET: ListScaffoldingTemplate
        static readonly List<Products> prod = new List<Products>()
        {
            new Products()
            {
                ProductName = "L. Laptop",
                ProductCost = 20000,
                ProductQuantity = 2,
                ProductTax = 20,
                Discontinued=true,
                ProductFinalPrice = 0,
                CategoryId = 3
            },

            new Products()
            {
                ProductName = "L. Laptop1",
                ProductCost = 20000,
                ProductQuantity = 4,
                ProductTax = 20,
                ProductFinalPrice = 0,
                CategoryId = 3
            },

            new Products()
            {
                ProductName = "L. Laptop2",
                ProductCost = 20000,
                ProductQuantity = 6,
                ProductTax = 20,
                ProductFinalPrice = 0,
                CategoryId = 3
            },

            new Products()
            {
                ProductName = "L. Laptop3",
                ProductCost = 20000,
                ProductQuantity = 8,
                ProductTax = 20,
                ProductFinalPrice = 0,
                CategoryId = 3
            }
        };
        public ActionResult Index()
        {
            return View(prod);
        }

        public ActionResult DisplayFullList()
        {
            var model = from p in prod
                        where p.ProductQuantity >= 4
                        select p;
                      
            return View(model);
        }
    }
}
using ScaffHoldingTemplates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScaffHoldingTemplates.Controllers
{
    public class StronglyTypedModelController : Controller
    {
        // GET: StronglyTypedModel
        [HttpGet]
        public ActionResult Index()
        {
            Products prod = new Products()
            {
                ProductName = "L. Laptop",
                ProductCost = 20000,
                ProductQuantity = 2,
                ProductTax = 20,
                ProductFinalPrice = 0,
                CategoryId = 3
            };

            List<Categories> list = new List<Categories>();

            list.Add(new Categories() {CategoryId=1,CategoryName="L1" });
            list.Add(new Categories() {CategoryId=2,CategoryName="L2" });
            list.Add(new Categories() {CategoryId=3,CategoryName="L3" });
            list.Add(new Categories() {CategoryId=4,CategoryName="L4" });

            SelectList sl = new SelectList(list, "CategoryId", "CategoryName", prod.CategoryId);
            TempData["categoryList"] = sl;
            TempData.Keep();

            return View(prod);
        }

        [HttpPost]
        public ActionResult Index(Products prod)
        {
            ModelState.Clear();
            var perMinus=prod.ProductCost * prod.ProductTax / 100;
            prod.ProductFinalPrice = prod.ProductCost-perMinus;
            TempData.Keep();

            return View(prod);
        }
    }
}
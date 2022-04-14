using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScaffHoldingTemplates.Models
{
    public class Categories
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
    public class Products
    {
        public string ProductName { get; set; }

        public int ProductCost { get; set; }

        public int ProductQuantity { get; set; }

        public int ProductTax { get; set; }

        public bool Discontinued { get; set; }

        public double ProductFinalPrice { get; set; }

        public int CategoryId { get; set; }
    }
}
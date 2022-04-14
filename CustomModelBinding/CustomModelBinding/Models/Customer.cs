using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomModelBinding.Models
{
    public class Customer
    {
        public string CustomerId { get; set; }

        public AddressDetails Present { get; set; }
    }

    public class AddressDetails
    {
        public string PresentCityName { get; set; }

        public string PresentStateName { get; set; }

        public string PresentCountryName { get; set; }
    }
}
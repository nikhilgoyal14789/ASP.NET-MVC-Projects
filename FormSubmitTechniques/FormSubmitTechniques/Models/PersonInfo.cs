using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormSubmitTechniques.Models
{
    public class PersonInfo
    {
        public string PersonId { get; set; }
        public string PersonName { get; set; }
        public string Photo { get; set; }

        public AddressDetail Address { get; set; }
        public AddressDetail Present { get; set; }
        public AddressDetail Permanent { get; set; }
    }

    public class AddressDetail
    {
        [System.ComponentModel.DataAnnotations.MinLength(3)]
        public string CityName { get; set; }

        public string StateName { get; set; }

        public string CountryName { get; set; }
    }
}
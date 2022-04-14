using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidationsWithDataAnnotations
{
    public class CityValidator
    {
        public static ValidationResult CityValidation(string cityName, ValidationContext context)
        {
            if (string.IsNullOrWhiteSpace(cityName))
                return new ValidationResult("City Name cannot be null or cannot contain White Spaces");
            else if (cityName.ToLower().Equals("agra"))
                return ValidationResult.Success;
            else
                return new ValidationResult("Your Entered City is not Agra");                 
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValidationsWithDataAnnotations.Models
{
    public class UserDetails : IValidatableObject
    {
        [Required(ErrorMessage ="UserName is Required")]
        [StringLength(20,MinimumLength =4,ErrorMessage ="UserName Minimum Length should be 4")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Password is Required")]
        [StringLength(20,MinimumLength =4,ErrorMessage ="Password Minimum Length should be 4")]
        //[DataType("password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [Display(Name ="Enter your Password Again")]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Password",ErrorMessage ="Your password is not matching")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage ="DOB is required")]
        [Display(Name ="Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:d}", ApplyFormatInEditMode =true)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage ="Email Address is Required")]
        [EmailAddress(ErrorMessage ="Please type Email Address in Correct Format")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Postal Code is Required")]
        [Range(100,1000000,ErrorMessage ="Invalid Postal Number")]
        public int PostalCode { get; set; }

        [Required(ErrorMessage ="Mobile Number is Required")]
        [DisplayName("Enter Your Phone Number")]
        public int MobileNumber { get; set; }

        [Required(ErrorMessage ="Profile Bio is Must")]
        [DataType(DataType.MultilineText)]

        public string Profile { get; set; }

        [Required(ErrorMessage ="Please Upload Your Photo")]  // this is the column level predefined validation
        [FileExtensions(Extensions ="jpg,png,jpeg,ico,gif")]
        public string Photo { get; set; }

        [AllowHtml()]   //It allows the user to enter the html code , javascript code , etc. inside additional comments and Note :  do this AllowHtml() for your own risk.
        [DisplayName("Enter Your Additional Comments")]
        public string AdditionalComments { get; set; }

        [CustomValidation(typeof(CityValidator),"CityValidation")]      // this is the column level custom validation
        public string City { get; set; }

        //We can also create model level validation by using IValidatableObject Interface.
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            ValidationResult vr= null;
            if (!City.Equals("Agra") && PostalCode != 283122)
                vr = new ValidationResult("Your City and Postal Code is Not Correct");

            return new List<ValidationResult>() { vr };
        }
    }
}
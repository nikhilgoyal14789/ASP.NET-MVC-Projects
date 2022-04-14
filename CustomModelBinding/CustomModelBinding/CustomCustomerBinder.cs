using CustomModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomModelBinding
{
    public class CustomCustomerBinder : System.Web.Mvc.IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            Customer cs;
            if(bindingContext.Model==null)
            {
                cs = new Customer();
                cs.Present = new AddressDetails();
            }
            else
            {
                //if UpdateModel(customer) or TryUpdateModel(customer) is used
                cs = (Customer)bindingContext.Model;
            }
            cs.CustomerId = GetValue<string>(bindingContext, "CustomerId");
            cs.Present.PresentCityName = GetValue<string>(bindingContext, "pc");
            cs.Present.PresentStateName = GetValue<string>(bindingContext, "ps");
            cs.Present.PresentCountryName = GetValue<string>(bindingContext, "pco");
            return cs;
        }

        private T GetValue<T> (ModelBindingContext bindingContext , string key)
        {
            ValueProviderResult valueResult = bindingContext.ValueProvider.GetValue(key);
            bindingContext.ModelState.SetModelValue(key, valueResult);
            return (T)valueResult.ConvertTo(typeof(T));
        }
    }
}
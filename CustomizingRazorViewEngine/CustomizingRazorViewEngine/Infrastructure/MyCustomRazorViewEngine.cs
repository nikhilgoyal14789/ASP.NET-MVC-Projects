using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomizingRazorViewEngine.Infrastructure
{
    public class MyCustomRazorViewEngine : RazorViewEngine
    {
        public MyCustomRazorViewEngine()
        {
            ViewLocationFormats = new string[]
            {
                "~/Views/{1}/{0}.cshtml" , "~/Views/MyCustom/{0}.cshtml"
            };
        }
    }
}
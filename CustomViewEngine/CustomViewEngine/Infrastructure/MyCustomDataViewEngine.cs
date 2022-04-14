using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomViewEngine.Infrastructure
{
    public class MyCustomDataViewEngine : IViewEngine
    {
        public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            return new ViewEngineResult(new string[] { "No View Found (MyCustomDataView)" });
        }

        public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            if (viewName == "MyCustomData")
                return new ViewEngineResult(new MyCustomDataView(), this);
            else
                return new ViewEngineResult(new string[] { "No View Found (MyCustomDataView)" });
        }

        public void ReleaseView(ControllerContext controllerContext, IView view)
        {
            //throw new NotImplementedException();
        }
    }
}
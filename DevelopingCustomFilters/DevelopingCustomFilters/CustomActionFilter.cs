using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DevelopingCustomFilters
{
    public class CustomActionFilter : ActionFilterAttribute
    {
        //This is code is excuting after the controller action is executing
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Logging("On Action Executed", filterContext.RouteData);
            //base.OnActionExecuted(filterContext);
        }

        //This code is executing even before your action is executing
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Logging("On Action Executing", filterContext.RouteData);
            //base.OnActionExecuting(filterContext);
        }

        //This is code is excuting after your view is rendered to the UI

        //This code is executing before you get redirected to the View
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //    int Hours=Convert.ToInt32(DateTime.Now.ToString("HH"));

            //    if (Hours<18)
            //    {
            //        filterContext.HttpContext.Response.Write("<br> You can't access the system before 8 pm <br>");
            //        filterContext.Cancel = true;
            //    }
            //    else
            Logging("On Result Executing", filterContext.RouteData);
            //base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Logging("On Result Executed", filterContext.RouteData);
            //base.OnResultExecuted(filterContext);
        }
        public void Logging(string functionName,RouteData routeData)
        {
            string controller = routeData.Values["controller"].ToString();
            string action = routeData.Values["action"].ToString();
            //int Hours = Convert.ToInt32(DateTime.Now.ToString("HH"));
            string result = string.Format("1:- Function Name : {0} , Controller Name : {1} , Action Name : {2}", functionName, controller, action);
            HttpContext.Current.Response.Write("<br><b>" +result + "</b><br>");
        }
    }

    public class NewCustomActionFilter : ActionFilterAttribute
    {
        //This is code is excuting after the controller action is executing
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Logging("On Action Executed", filterContext.RouteData);
            //base.OnActionExecuted(filterContext);
        }

        //This code is executing even before your action is executing
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Logging("On Action Executing", filterContext.RouteData);
            //base.OnActionExecuting(filterContext);
        }

        //This is code is excuting after your view is rendered to the UI

        //This code is executing before you get redirected to the View
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //int Hours = Convert.ToInt32(DateTime.Now.ToString("HH"));

            //if (Hours < 18)
            //{
            //    filterContext.HttpContext.Response.Write("<br> You can't access the system before 8 pm <br>");
            //    filterContext.Cancel = true;
            //}
            //else
                Logging("On Result Executing", filterContext.RouteData);
            //base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Logging("On Result Executed", filterContext.RouteData);
            //base.OnResultExecuted(filterContext);
        }
        public void Logging(string functionName, RouteData routeData)
        {
            string controller = routeData.Values["controller"].ToString();
            string action = routeData.Values["action"].ToString();
            //int Hours = Convert.ToInt32(DateTime.Now.ToString("HH"));
            string result = string.Format("2:- Function Name : {0} , Controller Name : {1} , Action Name : {2}", functionName, controller, action);
            HttpContext.Current.Response.Write("<br><b>" + result + "</b><br>");
        }
    }
}
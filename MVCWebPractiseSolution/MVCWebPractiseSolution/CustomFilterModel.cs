using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCWebPractiseSolution
{
    public class CustomFilterModel : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            DoLogging("On Action Executing", filterContext.RouteData);
            //base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            DoLogging("On Action Executed", filterContext.RouteData);
            //base.OnActionExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            int HH = Convert.ToInt32(DateTime.Now.ToString("HH"));
            if (HH < 10)
            {
                filterContext.HttpContext.Response.Write("You can't access this system before 11:59 AM");
                filterContext.Cancel = true;
            }
            DoLogging("On Result Executing", filterContext.RouteData);
            //base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            DoLogging("On Result Executed", filterContext.RouteData);
            //base.OnResultExecuted(filterContext);
        }

        private static void DoLogging(string functionName , RouteData routeData)
        {
            string controllerName = routeData.Values["controller"].ToString();
            string actionName = routeData.Values["action"].ToString();

            string result = string.Format("1: {0} {1} {2} ", controllerName, actionName, functionName);

            HttpContext.Current.Response.Write("<br><b>"+result+"</b><br>");
        }
    }
}
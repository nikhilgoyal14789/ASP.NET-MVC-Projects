using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //This is one of the approach to create our own Route by using Route Class.
            //Route newRoute = new Route("{controller}/{action}", new MvcRouteHandler());
            //routes.Add("NewRoute", newRoute);

            //Creating Static URL Segments
            // routes.MapRoute(
            //     name: "Default2",
            //     url: "Customer/{controller}/{action}/{id}",
            //     defaults: new { controller = "Home" , action= "About" , id=20}

            // );

            // routes.MapRoute(
            //     name: "Default3",
            //     url: "Customer{controller}/{action}/{id}",
            //     defaults: new {controller= "Home", action="Contact", id=40}

            // );

            // routes.MapRoute(
            //    name: "Default4",
            //    url: "Customer{controller}/Get{action}/{id}",
            //    defaults: new { controller = "Home", action = "Contact", id = 40 }

            //);

            //Variable Length Routes
            //routes.MapRoute(
            //  name: "Default",
            //  url: "{controller}/{action}/{id}/{*catchAll}",
            //  defaults: new { controller = "Home", action = "VariableLengthRoutes", id = 40 }

            //);


            //Prioritizing Controllers By Namespaces
            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    namespaces: new[] { "Routing.Controllers" }
            //);

            //Constraining a Route to a set of specific values 
            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    constraints: new { action = "Index|About" }
            //);

            //Constraining a Route using HTTP Methods 
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new { action = "Index|About|Contact", httpMethod = new HttpMethodConstraint("GET")}
            );

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyApp2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                //defaults: new { controller = "Book", action = "ListBooks", id = UrlParameter.Optional }
                //defaults: new { controller = "SignUp", action = "Register", id = UrlParameter.Optional }
                defaults: new { controller = "Partial", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

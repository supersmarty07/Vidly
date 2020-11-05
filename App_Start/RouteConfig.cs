using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Attribute-based routing
            routes.MapMvcAttributeRoutes();

            //Convention-based routing
            /*routes.MapRoute(
                "MoviesByReleaseDate",
                "movies/released/{year}/{month }",
                new {controller= "Movies", action = "ByReleaseDate" },
                new{year = @"2015|2016", month=@"\d{2}" }); //sets constraint of year to 4 digit and month to 2 */

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

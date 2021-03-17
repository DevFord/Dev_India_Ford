using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
namespace FordIndia.Feature.Locator.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            RouteTable.Routes.MapRoute(
                name: "dealerlocator",
                 url: "api/Locator/DealerLocator",
                 defaults: new { controller = "Locator", action = "DealerLocator", id = UrlParameter.Optional }
                );
        }
    }
}
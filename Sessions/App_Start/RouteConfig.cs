﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sessions
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}/{name}/{mobilenumber}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional , name = UrlParameter.Optional , mobilenumber = UrlParameter.Optional }
            );
        }
    }
}

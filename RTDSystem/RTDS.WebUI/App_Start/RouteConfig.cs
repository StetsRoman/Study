﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RTDS.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    "BranchRoute",
            //    "Branch/AddNewCity/{cityName}",
            //    new { controller = "Branch", action = "AddNewCity", id=UrlParameter.Optional }
            //    );
           
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new 
                { 
                    controller = "Home",
                    action = "Index", 
                    id = UrlParameter.Optional }
            );

           
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebApplication1.Controllers;

namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var namespaces = new[] { typeof(PostsController).Namespace };

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Home", "", new { Controller = "Posts", Action = "Index" }, namespaces);
            routes.MapRoute("Login", "login", new { Controller = "Auth", Action = "Login" }, namespaces);

        }
    }
}

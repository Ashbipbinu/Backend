using SampleBlog.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SampleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var namespaces = new [] {typeof(PostController).Namespace};
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Home", "", new { controller = "Post", action = "index" }, namespaces);
            routes.MapRoute("Login", "login", new { controller = "Auth", action = "Login" }, namespaces);
        }
    }
}

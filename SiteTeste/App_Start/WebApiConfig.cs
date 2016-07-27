using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SiteTeste
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                 "WithActionApi",
                 "api/{controller}/{action}/{id}",
                 new { action = "{action}", id = System.Web.Http.RouteParameter.Optional }
             );

            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new { action = "DefaultAction", id = System.Web.Http.RouteParameter.Optional }
            );
        }
    }
}

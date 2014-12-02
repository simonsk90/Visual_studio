using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MvcApplication1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //config.Routes.MapHttpRoute(
            //    name: "ApiByAction",
            //    routeTemplate: "api/{controller}/{action}",
            //    defaults: new { action = "Get" }
            //);
        }
    }
}

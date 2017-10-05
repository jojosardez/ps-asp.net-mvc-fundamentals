using System.Web.Mvc;
using System.Web.Routing;

namespace MvcControllers
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "SayHello",
                "Hello",
                new
                {
                    controller = "Hello"
                }
            );

            routes.MapRoute(
                "SayHello2",
                "Hello2",
                new
                {
                    controller = "Hello2",
                    action = "SayHello",
                    id = 99
                }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

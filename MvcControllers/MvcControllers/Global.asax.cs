using MvcControllers.Controllers;
using MvcControllers.Infrastructure;
using StructureMap;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MvcControllers
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ControllerBuilder.Current.SetControllerFactory(new MyControllerFactory(ConfigureContainer()));
        }

        private Container ConfigureContainer()
        {
            var container = new Container(c =>
            {
                c.For<ILogger>().Use<ConsoleLogger>();
                c.For<HomeController>().Use<HomeController>();
                c.For<HelloController>().Use<HelloController>();
            });

            return container;
        }
    }
}

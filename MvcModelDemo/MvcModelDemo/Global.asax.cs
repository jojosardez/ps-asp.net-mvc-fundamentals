using MvcModelDemo.Binders;
using System;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MvcModelDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            RegisterModelBinders();
        }

        private void RegisterModelBinders()
        {
            ModelBinders.Binders.Add(typeof(DateTime), new DateTimeModelBinder());
        }
    }
}

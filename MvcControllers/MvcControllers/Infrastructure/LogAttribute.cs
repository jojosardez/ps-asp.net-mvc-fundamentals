using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcControllers.Infrastructure
{
    public class LogAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log("Action Executing", filterContext.RouteData);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log("Action Executed", filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Log("Result Executing", filterContext.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Log("Result Executed", filterContext.RouteData);
        }

        private void Log(string stageName, RouteData routeData)
        {
            Debug.WriteLine($"{routeData.Values["controller"]}::{routeData.Values["action"]} - {stageName}");
        }
    }
}
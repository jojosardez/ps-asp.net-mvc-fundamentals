using System.Web.Mvc;
using System.Web.Routing;

namespace MvcControllers.Controllers
{
    public class HelloController : IController
    {
        public void Execute(RequestContext requestContext)
        {
            requestContext.HttpContext.Response.Write("Hello, World");
        }
    }
}
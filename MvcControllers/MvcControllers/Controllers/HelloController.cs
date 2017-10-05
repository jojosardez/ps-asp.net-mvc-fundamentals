using MvcControllers.Infrastructure;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcControllers.Controllers
{
    public class HelloController : IController
    {
        private readonly ILogger _logger;

        public HelloController(ILogger logger)
        {
            _logger = logger;
        }

        public void Execute(RequestContext requestContext)
        {
            requestContext.HttpContext?.Response?.Write("Hello, World");
            _logger.Log("Message");
        }
    }
}
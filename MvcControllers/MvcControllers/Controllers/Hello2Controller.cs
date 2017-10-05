using MvcControllers.Infrastructure;
using System.Web.Mvc;

namespace MvcControllers.Controllers
{
    public class Hello2Controller : Controller
    {
        [Log]
        public string SayHello(int id)
        {
            return "Hello, World! v2.0 " + id.ToString();
        }
    }
}
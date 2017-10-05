using MvcControllers.Infrastructure;
using System.Web.Mvc;

namespace MvcControllers.Controllers
{
    public class Hello2Controller : Controller
    {
        [Log]
        public ActionResult SayHello(int id)
        {
            ViewData["id"] = id;
            return View("Hello");
        }
    }
}
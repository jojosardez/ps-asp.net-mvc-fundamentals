using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;

namespace MvcDemo.Controllers
{
    public class ProcessController : Controller
    {
        // GET: Process/List
        public ViewResult List()
        {
            var processList = from p in Process.GetProcesses()
                select p;
            
            return View(processList.ToList());
        }

        // GET: Process/Details/5
        public ActionResult Details(int id)
        {
            var process = (from p in Process.GetProcesses()
                where p.Id == id
                select p).Single();

            return View(process);
        }
    }
}

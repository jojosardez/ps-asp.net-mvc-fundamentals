using MovieTheaterDomain;
using System.Linq;
using System.Web.Mvc;

namespace MvcModelDemo.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index(string q)
        {
            using (var ctx = new MoviesContext())
            {
                var movies = ctx.MovieSet
                    .Where(m => m.Title.StartsWith(q) || q == null)
                    .OrderByDescending(m => m.Reviews.Average(r => r.Rating))
                    .Take(10)
                    .Select(m => new MovieSummary
                        {
                            ID = m.ID,
                            AverageRating = m.Reviews.Average(r => r.Rating),
                            ReleaseDate = m.ReleaseDate,
                            Title = m.Title
                        })
                    .ToList();

                return View(movies);
            }
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            using (var ctx = new MoviesContext())
            {
                var movie = ctx.MovieSet
                    .Include("Reviews")
                    .Where(m => m.ID == id)
                    .First();


                return View(movie);
            }
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "ID")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                using (var ctx = new MoviesContext())
                {
                    ctx.MovieSet.Add(movie);
                    ctx.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Movie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Movie/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

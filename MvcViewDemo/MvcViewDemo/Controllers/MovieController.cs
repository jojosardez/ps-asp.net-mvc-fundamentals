﻿using MvcContrib.Pagination;
using MvcViewDemo.Models;
using System.Linq;
using System.Web.Mvc;

namespace MvcViewDemo.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index(int? page)
        {
            var ctx = new MoviesContext();

            //var movies = ctx.Movies
            //    .OrderByDescending(m => m.ReleaseDate)
            //    .Take(10);

            var movies = ctx.Movies
                .OrderByDescending(m => m.ReleaseDate)
                .AsPagination(page ?? 1, 5);

            return View(movies);
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            var ctx = new MoviesContext();
            var movie = ctx.Movies.Where(m => m.ID == id).First();

            return View(movie);
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

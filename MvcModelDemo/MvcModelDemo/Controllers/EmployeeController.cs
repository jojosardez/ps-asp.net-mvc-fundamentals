﻿using System;
using MovieTheaterDomain;
using System.Web.Mvc;

namespace MvcModelDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var repository = new EmployeeRepository();
            var employees = repository.FindAll();

            return View(employees);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
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

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            var repository = new EmployeeRepository();
            var employee = repository.FindByID(id);

            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, string name, DateTime? hireDate)
        {
            var repository = new EmployeeRepository();
            var employee = repository.FindByID(id);

            if (ModelState.IsValid)
            {
                employee.Name = name;
                employee.HireDate = hireDate.Value;
                repository.Save(employee);

                return RedirectToAction("Index");
            }

            if (!hireDate.HasValue)
            {
                ModelState.AddModelError("HireDate", "Could not parse the datetime value");
            }

            return View(employee);
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreAssignment.Controllers
{
    public class CastsController : Controller
    {
        // GET: Casts
        public ActionResult Index()
        {
            return View();
        }

        // GET: Casts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Casts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Casts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Casts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Casts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Casts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Casts/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
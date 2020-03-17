using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using superHerosproject.Models;

namespace superHerosproject.Controllers
{
    public class HerosController : Controller
    {
        // GET: Heros
        public ActionResult Index()
        {
            return View();
        }

        // GET: Heros/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Heros/Create
        public ActionResult Create()
        {
            SuperHero heros = new SuperHero();
            return View(heros);
        }

        // POST: Heros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuperHero heros)
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

        // GET: Heros/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Heros/Edit/5
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

        // GET: Heros/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Heros/Delete/5
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
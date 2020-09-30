using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebScraper.WEB.Controllers
{
    public class ScraperController : Controller
    {
        // GET: Scraper
        public ActionResult Index()
        {
            return View();
        }

        // GET: Scraper/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Scraper/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Scraper/Create
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

        // GET: Scraper/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Scraper/Edit/5
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

        // GET: Scraper/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Scraper/Delete/5
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
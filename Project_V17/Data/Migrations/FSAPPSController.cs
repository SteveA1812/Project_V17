using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project_V17.Data.Migrations
{
    public class FSAPPSController : Controller
    {





        // GET: FSAPPS
        public ActionResult Index()
        {
            return View();
        }

        // GET: FSAPPS/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FSAPPS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FSAPPS/Create
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

        // GET: FSAPPS/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FSAPPS/Edit/5
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

        // GET: FSAPPS/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FSAPPS/Delete/5
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
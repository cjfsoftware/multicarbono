using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Controllers
{
    public class TransportadorController : Controller
    {
        // GET: TransportadorController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TransportadorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TransportadorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TransportadorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TransportadorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TransportadorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TransportadorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TransportadorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

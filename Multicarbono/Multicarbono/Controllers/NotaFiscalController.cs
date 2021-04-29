using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Controllers.Default
{
    public class NotaFiscalController : Controller
    {
        // GET: NotaFiscalController
        public ActionResult Index()
        {
            return View();
        }

        // GET: NotaFiscalController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NotaFiscalController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NotaFiscalController/Create
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

        // GET: NotaFiscalController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NotaFiscalController/Edit/5
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

        // GET: NotaFiscalController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NotaFiscalController/Delete/5
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

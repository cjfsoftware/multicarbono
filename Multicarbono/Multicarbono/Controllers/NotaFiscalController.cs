using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multicarbono.Models.NotaFiscal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Controllers
{
    public class NotaFiscalController : Controller
    {
        private NotaFiscalRepository _notaRepo;

        public NotaFiscalController(NotaFiscalRepository notaFiscalRepo)
        {
            _notaRepo = notaFiscalRepo;
        }



        public ActionResult Index()
        {
            var model = _notaRepo.ListNotaFiscal();
            return PartialView("Index", model);
        }

        public ActionResult CadastroNotaFiscal()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastroNotaFiscal(NotaFiscal notaFiscal)
        {
            _notaRepo.IncludeNota(notaFiscal);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int idNotaFiscal)
        {
            var model = _notaRepo.NotaById(idNotaFiscal);
            return PartialView("_alterarItemNotaPartial", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int idNotaFiscal, NotaFiscal notaFiscal)
        {
            try
            {
                _notaRepo.UpdateNota(notaFiscal);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int idNotaFiscal)
        {
            var model = _notaRepo.NotaById(idNotaFiscal);
            return PartialView("modalConfirmDeleteNota", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int idNotaFiscal, NotaFiscal notaFiscal)
        {
            try
            {
                _notaRepo.DeleteNota(notaFiscal.IdNF);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

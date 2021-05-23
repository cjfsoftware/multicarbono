using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multicarbono.Models.Telefone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Controllers
{
    public class TelefoneController : Controller
    {
        private TelefoneRepository _telefoneRepo;

        public TelefoneController(TelefoneRepository telefoneRepo)
        {
            _telefoneRepo = telefoneRepo;
        }


        public ActionResult Index()
        {
            var model = _telefoneRepo.ListTelefone();
            return PartialView("Index", model);
        }

        public ActionResult CadastroTelefone()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastroTelefone(int idTelefone, Telefone telefone)
        {
            _telefoneRepo.IncludeTelefone(telefone);
            return RedirectToAction("Index");
        }



        public ActionResult Edit(int idTelefone)
        {

            var model = _telefoneRepo.TelefoneById(idTelefone);
            return PartialView("AlterarTelefone", model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int idTelefone, Telefone telefone)
        {
            try
            {
                _telefoneRepo.UpdateTelefone(telefone);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                //return View();
                return RedirectToAction(nameof(Index));
            }
        }


        public ActionResult Delete(int idTelefone)
        {
            var model = _telefoneRepo.TelefoneById(idTelefone);
            return PartialView("modalConfirmDelete", model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int idTelefone, Telefone telefone)
        {
            try
            {
                _telefoneRepo.DeleteTelefone(telefone.IdTelefone);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

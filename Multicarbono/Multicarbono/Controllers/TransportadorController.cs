using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multicarbono.Models.Transportador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Controllers
{
    public class TransportadorController : Controller
    {
        private TransportadorRepository _transportadorRepo;

        public TransportadorController(TransportadorRepository transportadorRepo)
        {
            _transportadorRepo = transportadorRepo;
        }


        public ActionResult Index()
        {
            var model = _transportadorRepo.ListTransportador();
            return PartialView("Index", model);
        }

        public ActionResult CadastroTransportador()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastroTransportador(int idTransportador, Transportador transportador)
        {
            _transportadorRepo.IncludeTransportador(transportador);
            return RedirectToAction("Index");
        }



        public ActionResult Edit(int idTransportador)
        {

            var model = _transportadorRepo.TransportadorById(idTransportador);
            return PartialView("AlterarTransportador", model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int idTransportador, Transportador transportador)
        {
            try
            {
                _transportadorRepo.UpdateTransportador(transportador);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                //return View();
                return RedirectToAction(nameof(Index));
            }
        }


        public ActionResult Delete(int idTransportador)
        {
            var model = _transportadorRepo.TransportadorById(idTransportador);
            return PartialView("modalConfirmDelete", model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int idTransportador, Transportador transportador)
        {
            try
            {
                _transportadorRepo.DeleteTransportador(transportador.IdTransportador);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

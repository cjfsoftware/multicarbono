using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multicarbono.Models.Telefone;
using Multicarbono.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Controllers
{
    public class TelefoneController : Controller
    {
        private TelefoneRepository _telefoneRepo;
        private Models.Cliente.ClienteRepository _clienteRepo;

        public TelefoneController(TelefoneRepository telefoneRepo, Models.Cliente.ClienteRepository clienteRepo)
        {
            _telefoneRepo = telefoneRepo;
            _clienteRepo = clienteRepo;
        }


        public ActionResult Index()
        {
            var model = _telefoneRepo.ListTelefone();
            return PartialView("Index", model);
        }

        public ActionResult CadastroTelefone(int idCliente, CadastroTelefoneViewModel viewModel)
        {
            viewModel.Cliente = _clienteRepo.ClienteById(idCliente);

            return PartialView(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastroTelefone(CadastroTelefoneViewModel viewModel)
        {

            viewModel.Telefone.IdCliente = viewModel.Cliente.IdCliente;

            _telefoneRepo.IncludeTelefone(viewModel.Telefone);
            return RedirectToAction("Details", "Cliente", new { idCliente = viewModel.Cliente.IdCliente });
        }



        public ActionResult Edit(int idTelefone)
        {

            var model = _telefoneRepo.TelefoneById(idTelefone);
            return PartialView("AlterarTelefone", model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int idTelefone, CadastroTelefoneViewModel telefone)
        {
            try
            {
                _telefoneRepo.UpdateTelefone(telefone.Telefone);
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
        public ActionResult Delete(int idTelefone, CadastroTelefoneViewModel telefone)
        {
            try
            {
                _telefoneRepo.DeleteTelefone(idTelefone);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                throw;
                return RedirectToAction(nameof(Index));
            }
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multicarbono.Models.EnderecoCliente;
using Multicarbono.Models.Telefone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Controllers
{
    public class EnderecoClienteController : Controller
    {
        private EnderecoClienteRepository _enderecoClienteRepo;

        public EnderecoClienteController(EnderecoClienteRepository enderecoClienteRepo)
        {
            _enderecoClienteRepo = enderecoClienteRepo;
        }


        public ActionResult Index()
        {
            var model = _enderecoClienteRepo.ListEndereco();
            return PartialView("Index", model);
        }

        public ActionResult CadastroEndereco()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastroEndereco(int idEnderecoCliente, EnderecoCliente enderecoCliente)
        {
            _enderecoClienteRepo.IncludeEndereco(enderecoCliente);
            return RedirectToAction("Index");
        }



        public ActionResult Edit(int idEndereco)
        {

            var model = _enderecoClienteRepo.EnderecoById(idEndereco);
            return PartialView("AlterarEndereco", model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int idEnderecoCliente, EnderecoCliente enderecoCliente)
        {
            try
            {
                _enderecoClienteRepo.UpdateEndereco(enderecoCliente);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                //return View();
                return RedirectToAction(nameof(Index));
            }
        }


        public ActionResult Delete(int idEnderecoCliente)
        {
            var model = _enderecoClienteRepo.EnderecoById(idEnderecoCliente);
            return PartialView("modalConfirmDelete", model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int idEnderecoCliente, EnderecoCliente enderecoCliente)
        {
            try
            {
                _enderecoClienteRepo.DeleteEndereco(enderecoCliente.IdEndereco);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

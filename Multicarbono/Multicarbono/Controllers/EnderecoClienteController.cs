using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multicarbono.Models.Cliente;
using Multicarbono.Models.EnderecoCliente;
using Multicarbono.Models.Telefone;
using Multicarbono.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Controllers
{
    public class EnderecoClienteController : Controller
    {
        private EnderecoClienteRepository _enderecoClienteRepo;
        private Models.Cliente.ClienteRepository _clienteRepo;

        public EnderecoClienteController(EnderecoClienteRepository enderecoClienteRepo, ClienteRepository clienteRepository)
        {
            _enderecoClienteRepo = enderecoClienteRepo;
            _clienteRepo = clienteRepository;
        }


        public ActionResult Index()
        {
            var model = _enderecoClienteRepo.ListEndereco();
            return PartialView("Index", model);
        }

        public ActionResult CadastroEndereco(int idCliente, CadastroEnderecoViewModel viewModel)
        {

            viewModel.Cliente = _clienteRepo.ClienteById(idCliente);

            return PartialView("CadastroEndereco", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastroEndereco(CadastroEnderecoViewModel viewModel)
        {

            viewModel.Endereco.IdCliente = viewModel.Cliente.IdCliente;

            _enderecoClienteRepo.IncludeEndereco(viewModel.Endereco);
            return RedirectToAction("Details", "Cliente", new { idCliente = viewModel.Cliente.IdCliente });
        }



        public ActionResult Edit(int idEnderecoCliente)
        {

            var model = _enderecoClienteRepo.EnderecoById(idEnderecoCliente);
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

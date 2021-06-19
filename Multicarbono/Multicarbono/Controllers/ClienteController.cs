using Microsoft.AspNetCore.Mvc;
using Multicarbono.Models.Cliente;
using Multicarbono.Models.EnderecoCliente;
using Multicarbono.Models.Telefone;
using Multicarbono.ViewModels;
using System;

namespace Multicarbono.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteRepository _clienteRepo;
        private EnderecoClienteRepository _enderecoRepo;
        private TelefoneRepository _telefoneRepo;

        public ClienteController(ClienteRepository clienteRepo, EnderecoClienteRepository enderecoRepo, TelefoneRepository telefoneRepo)
        {
            _clienteRepo = clienteRepo;
            _enderecoRepo = enderecoRepo;
            _telefoneRepo = telefoneRepo;
        }



        // GET: ClienteController
        public ActionResult Index()
        {
            var model = _clienteRepo.ListCliente();
            return PartialView("Index", model);
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int idCliente, DetalhesClienteViewModel viewModel)
        {
            viewModel.Cliente = _clienteRepo.ClienteById(idCliente);
            viewModel.Telefones = _telefoneRepo.TelefoneByCliente(idCliente);
            viewModel.Enderecos = _enderecoRepo.EnderecoByCliente(idCliente);

            return View("DetalhesCliente", viewModel);
        }

        // GET: ClienteController/Create
        public ActionResult CadastroCliente(Cliente cliente, string dif = "")
        {

            cliente.DtCadastro = DateTime.Now;

            return PartialView(cliente);
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastroCliente(Cliente cliente)
        {
                _clienteRepo.IncludeCliente(cliente);
                return RedirectToAction("Index"); 
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int idCliente)
        {
            var model = _clienteRepo.ClienteById(idCliente);
            return PartialView("AlterarCliente", model);
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int idCliente, Cliente cliente)
        {
            try
            {
                _clienteRepo.UpdateCliente(cliente);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int idCliente)
        {
            var model = _clienteRepo.ClienteById(idCliente);
            return PartialView("modalConfirmDelete", model);
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int idCliente, Cliente cliente)
        {
            try
            {
                _clienteRepo.DeleteCliente(cliente.IdCliente);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

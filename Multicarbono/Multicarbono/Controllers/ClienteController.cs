using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multicarbono.Models.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteRepository _clienteRepo;

        public ClienteController(ClienteRepository clienteRepo)
        {
            _clienteRepo = clienteRepo;
        }



        // GET: ClienteController
        public ActionResult Index()
        {
            var model = _clienteRepo.ListCliente();
            return PartialView("Index", model);
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClienteController/Create
        public ActionResult CadastroCliente()
        {
            return PartialView();
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

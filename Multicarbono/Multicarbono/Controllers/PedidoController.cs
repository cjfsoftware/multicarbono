using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multicarbono.Models.Pedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Multicarbono.Controllers
{
    public class PedidoController : Controller
    {
        private PedidoRepository _pedidoRepo;

        public PedidoController(PedidoRepository pedidoRepo)
        {
            _pedidoRepo = pedidoRepo;
        }



        public ActionResult Index()
        {
            var model = _pedidoRepo.ListPedido();
            return PartialView("Index", model);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult CadastroPedido()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastroPedido(Pedido pedido)
        {
            _pedidoRepo.IncludePedido(pedido);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int idPedido)
        {
            var model = _pedidoRepo.PedidoById(idPedido);
            return PartialView("AlterarPedido", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int idPedido, Pedido pedido)
        {
            try
            {
                _pedidoRepo.UpdatePedido(pedido);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int idPedido)
        {
            var model = _pedidoRepo.PedidoById(idPedido);
            return PartialView("modalConfirmDelete", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int idPedido, Pedido pedido)
        {
            try
            {
                _pedidoRepo.DeletePedido(pedido.IdPedido);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

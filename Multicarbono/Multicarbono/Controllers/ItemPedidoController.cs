using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multicarbono.Models.ItemPedido;
using Multicarbono.Models.Pedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Multicarbono.Controllers
{
    public class ItemPedidoController : Controller
    {
        private ItemPedidoRepository _itemPedidoRepo;

        public ItemPedidoController(ItemPedidoRepository itemPedidoRepo)
        {
            _itemPedidoRepo = itemPedidoRepo;
        }

        public ActionResult Index(int idPedido)
        {
            var model = _itemPedidoRepo.ItemPedidoByPedido(idPedido);

            return PartialView("~/Views/Pedido/_itensPedido.cshtml", model);
        }

        public ActionResult CadastroItemPedido(int idPedido)
        {
            ViewData["idPedido"] = idPedido;
            return PartialView("~/Views/Pedido/_cadastroItemPedidoPartial.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastroItemPedido(ItemPedido itemPedido)
        {
            _itemPedidoRepo.IncludeItemPedido(itemPedido);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int idPedido)
        {
            var model = _itemPedidoRepo.ItemPedidoById(idPedido);
            return PartialView("~/Views/Pedido/_alterarItemPedidoPartial.cshtml", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int idIemPedido, ItemPedido itemPedido)
        {
            try
            {
                _itemPedidoRepo.UpdateItemPedido(itemPedido);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int idItemPedido)
        {
            var model = _itemPedidoRepo.ItemPedidoById(idItemPedido);
            return PartialView("~/Views/Pedido/modalConfirmDeleteItemPedido.cshtml", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int idItemPedido, ItemPedido itemPedido)
        {
            try
            {
                _itemPedidoRepo.DeleteItemPedido(itemPedido.IdItemPedido);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

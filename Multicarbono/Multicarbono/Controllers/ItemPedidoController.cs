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

        public ActionResult CadastroItemPedido()
        {
            return PartialView("_cadastroItemPedidoPartial");
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
            return PartialView("_alterarItemPedidoPartial", model);
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
            return PartialView("modalConfirmDeleteItemPedido", model);
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

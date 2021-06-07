using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multicarbono.Models.ItemNota;
using Multicarbono.Models.ItemPedido;
using Multicarbono.Models.Pedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Multicarbono.Controllers
{
    public class ItemNotaController : Controller
    {
        private ItemNotaRepository _itemNotaRepo;
        private ItemPedidoRepository _itemPedidoRepo;

        public ItemNotaController(ItemNotaRepository itemNotaRepo)
        {
            _itemNotaRepo = itemNotaRepo;
        }

        public ActionResult CadastroItemNota(int? idPedido)
        {
            var model = _itemNotaRepo.ItemNotaByPedido(idPedido);
            return PartialView("/Views/NotaFiscal/EmitirNota.cshtml", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastroItemNota(ItemNota itemNota)
        {
            _itemNotaRepo.IncludeItemNota(itemNota);

            return RedirectToAction("CadastroNotaFiscal","NotaFiscal", new {idPedido = TempData["idPedido"]});
        }

        public ActionResult Edit(int idItemNota)
        {
            var model = _itemNotaRepo.ItemNotaById(idItemNota);
            return PartialView("_alterarItemNotaPartial", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int idItemNota, ItemNota itemNota)
        {
            try
            {
                _itemNotaRepo.UpdateItemNota(itemNota);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int idItemNota)
        {
            var model = _itemNotaRepo.ItemNotaById(idItemNota);
            return PartialView("modalConfirmDeleteItemNota", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int idItemNota, ItemNota itemNota)
        {
            try
            {
                _itemNotaRepo.DeleteItemNota(itemNota.IdItemNF);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

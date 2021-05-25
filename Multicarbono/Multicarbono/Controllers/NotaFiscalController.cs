using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multicarbono.Models.ItemPedido;
using Multicarbono.Models.NotaFiscal;
using Multicarbono.Models.Pedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Controllers
{
    public class NotaFiscalController : Controller
    {
        private NotaFiscalRepository _notaRepo;
        private PedidoRepository _pedidoRepo;
        private ItemPedidoRepository _itemPedidoRepo;

        public NotaFiscalController(NotaFiscalRepository notaFiscalRepo, PedidoRepository pedidoRepo, ItemPedidoRepository itemPedidoRepo)
        {
            _notaRepo = notaFiscalRepo;
            _pedidoRepo = pedidoRepo;
            _itemPedidoRepo = itemPedidoRepo;
        }



        public ActionResult Index()
        {
            var model = _notaRepo.ListNotaFiscal();
            return PartialView("Index", model);
        }

        public ActionResult CadastroNotaFiscal(int idPedido)
        {
            var pedido = _pedidoRepo.PedidoById(idPedido);

            List<ItemPedido> itensPedido = new List<ItemPedido>();

            itensPedido = _itemPedidoRepo.ItemPedidoByPedido(idPedido);

            ViewBag.pedido = pedido;
            ViewBag.itensPedido = itensPedido;

            return PartialView("EmitirNota");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastroNotaFiscal(NotaFiscal notaFiscal)
        {
            _notaRepo.IncludeNota(notaFiscal);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int idNotaFiscal)
        {
            var model = _notaRepo.NotaById(idNotaFiscal);
            return PartialView("_alterarItemNotaPartial", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int idNotaFiscal, NotaFiscal notaFiscal)
        {
            try
            {
                _notaRepo.UpdateNota(notaFiscal);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int idNotaFiscal)
        {
            var model = _notaRepo.NotaById(idNotaFiscal);
            return PartialView("modalConfirmDeleteNota", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int idNotaFiscal, NotaFiscal notaFiscal)
        {
            try
            {
                _notaRepo.DeleteNota(notaFiscal.IdNF);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

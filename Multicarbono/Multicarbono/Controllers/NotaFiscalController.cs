using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Multicarbono.Models.ItemNota;
using Multicarbono.Models.ItemPedido;
using Multicarbono.Models.NotaFiscal;
using Multicarbono.Models.Pedido;
using Multicarbono.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Controllers
{
    public class NotaFiscalController : Controller
    {
        private NotaFiscalRepository _notaRepo;
        private ItemNotaRepository _itemNotaRepo;
        private PedidoRepository _pedidoRepo;
        private ItemPedidoRepository _itemPedidoRepo;

        public NotaFiscalController(NotaFiscalRepository notaFiscalRepo, PedidoRepository pedidoRepo, ItemPedidoRepository itemPedidoRepo, ItemNotaRepository itemNotaRepo)
        {
            _notaRepo = notaFiscalRepo;
            _pedidoRepo = pedidoRepo;
            _itemPedidoRepo = itemPedidoRepo;
            _itemNotaRepo = itemNotaRepo;
        }


        public ActionResult Index()
        {
            var model = _notaRepo.ListNotaFiscal();
            return PartialView("Index", model);
        }

        public ActionResult CadastroNotaFiscal(int idPedido)
        {
            var pedido = _pedidoRepo.PedidoById(idPedido);

            List<ItemPedido> itensPedido = new List<ItemPedido>(_itemPedidoRepo.ItemPedidoByPedido(idPedido));

            NotaViewModel vmNota = new NotaViewModel();

            vmNota.ItemNota = new List<ItemNota>();
            foreach (ItemPedido ip in itensPedido)
            {
                vmNota.ItemNota.Add(new ItemNota
                {
                    IdItemPedido = ip.IdItemPedido,
                    QtdePedido = ip.QTDE,
                    CodProduto = ip.CodProduto,
                    SubtotalItemNota = ip.SubtotalItemPedido
                });
            }


            ////TempData["Pedido"] = Newtonsoft.Json.JsonConvert.SerializeObject(GetItensPedidoNF(idPedido));
            //TempData["idPedido"] = idPedido;
            //TempData.Keep("Pedido");
            //TempData.Keep("idPedido");

            ////TempData["ItensNota"] = Newtonsoft.Json.JsonConvert.SerializeObject(_itemNotaRepo.ItemNotaByPedido(idPedido));
            //TempData.Keep("ItensNota");

            if (pedido.NFEmitida == true)
            {
                Response.WriteAsync("<script language='javascript'>alert('NF ja emitida para este pedido')</script>");
                return RedirectToAction("Index", "Pedido");
            }
            else
            
                return PartialView("EmitirNota", vmNota);
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
            return PartialView("AlterarNota", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int idNotaFiscal, NotaFiscal notaFiscal)
        {
            try
            {
                _notaRepo.UpdateNota(notaFiscal);
                return RedirectToAction("Index");
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
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

     
        public List<ItemPedido> GetItensPedidoNF(int idPedido)
        {
            var viewmodel = _itemPedidoRepo.ItemPedidoByPedido(idPedido);
            //TempData["idPedido"] = idPedido;

            return viewmodel;
        }

    }
}

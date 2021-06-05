using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Multicarbono.Models.ItemPedido;
using Multicarbono.Models.Pedido;
using Multicarbono.Models.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Multicarbono.Controllers
{
    public class ItemPedidoController : Controller
    {
        private ItemPedidoRepository _itemPedidoRepo;
        private ProdutoRepository _produtoRepo;

        public ItemPedidoController(ItemPedidoRepository itemPedidoRepo, ProdutoRepository produtoRepo)
        {
            _itemPedidoRepo = itemPedidoRepo;
            _produtoRepo = produtoRepo;
        }

        public ActionResult Index(int idPedido)
        {
            var model = _itemPedidoRepo.ItemPedidoByPedido(idPedido);
            TempData["idPedido"] = idPedido;
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
            decimal valProduto = _produtoRepo.ProdutoById(itemPedido.IdProduto).VrUnitario;
            _itemPedidoRepo.IncludeItemPedido(itemPedido, valProduto);
            return RedirectToAction("Index", new { idPedido = itemPedido.IdPedido });
        }

        public ActionResult Edit(int idItemPedido)
        {
            var model = _itemPedidoRepo.ItemPedidoById(idItemPedido);
            return PartialView("~/Views/Pedido/_alterarItemPedidoPartial.cshtml", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int idItemPedido, ItemPedido itemPedido)
        {
            try
            {
                decimal valProduto = _produtoRepo.ProdutoById(itemPedido.IdProduto).VrUnitario;
                _itemPedidoRepo.UpdateItemPedido(itemPedido, valProduto);
                return RedirectToAction("Index", new { idPedido = itemPedido.IdPedido });

            }
            catch(Exception e)
            {
                throw;
                return RedirectToAction("Index");
            }
        }

        public ActionResult Delete(int idItemPedido)
        {
            var model = _itemPedidoRepo.ItemPedidoById(idItemPedido);
            TempData["ItemPedido"] = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            TempData.Keep("ItemPedido");
            return PartialView("~/Views/Pedido/modalConfirmDeleteItemPedido.cshtml", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int idItemPedido, ItemPedido? itemPedido)
        {
            try
            {
                _itemPedidoRepo.DeleteItemPedido(idItemPedido);
                ItemPedido getModel = Newtonsoft.Json.JsonConvert.DeserializeObject<ItemPedido>(TempData["ItemPedido"].ToString()) as ItemPedido;
                return RedirectToAction("Index", new { idPedido = getModel.IdPedido });

            }
            catch
            {
                return View();
            }
        }
    }
}

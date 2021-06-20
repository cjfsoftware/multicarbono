using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Multicarbono.Models.ItemPedido;
using Multicarbono.Models.Pedido;
using Multicarbono.Models.Produto;
using Multicarbono.ViewModels;
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
            var pedidos = _itemPedidoRepo.ItemPedidoByPedido(idPedido);

            var viewModel = new ItensPedidoViewModel();

            viewModel.itens = new List<ItensPedidoItemViewModel>();
            viewModel.pedidoId = idPedido;

            pedidos.ForEach(p =>
            {
                viewModel.itens.Add(new ItensPedidoItemViewModel
                {
                    item = p,
                    produto = _produtoRepo.ProdutoById(p.IdProduto)
                });
            });

            return PartialView("~/Views/Pedido/_itensPedido.cshtml", viewModel);
        }

        public ActionResult CadastroItemPedido(int idPedido)
        {

            ItemPedidoViewModel vmItemPedido = new ItemPedidoViewModel();

            vmItemPedido.Produto = new List<SelectListItem>();
            foreach (Produto p in _produtoRepo.ListProduto())
            {
                vmItemPedido.Produto.Add(new SelectListItem
                {
                    Value = p.IdProduto.ToString(),
                    Text = p.Descricao
                });
            }

            vmItemPedido.ItemPedido = new ItemPedido();

            vmItemPedido.ItemPedido.IdPedido = idPedido;

            return PartialView("~/Views/Pedido/_cadastroItemPedidoPartial.cshtml", vmItemPedido);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastroItemPedido(ItemPedido itemPedido)
        {
            decimal valProduto = _produtoRepo.ProdutoById(itemPedido.IdProduto).VrUnitario;
            _itemPedidoRepo.IncludeItemPedido(itemPedido, valProduto);

            return RedirectToAction("Index", new { idPedido = itemPedido.IdPedido });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastroItemPedidoPedido(ItemPedido itemPedido)
        {
            decimal valProduto = _produtoRepo.ProdutoById(itemPedido.IdProduto).VrUnitario;
            _itemPedidoRepo.IncludeItemPedido(itemPedido, valProduto);
            return RedirectToAction("CadastroPedido", "Pedido", new { idPedido = itemPedido.IdPedido });
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

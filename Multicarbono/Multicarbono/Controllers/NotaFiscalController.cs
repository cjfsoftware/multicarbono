using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Multicarbono.Models.Cliente;
using Multicarbono.Models.ItemNota;
using Multicarbono.Models.ItemPedido;
using Multicarbono.Models.NotaFiscal;
using Multicarbono.Models.Pedido;
using Multicarbono.Models.Produto;
using Multicarbono.Models.Transportador;
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
        private ClienteRepository _clienteRepo;
        private Models.Produto.ProdutoRepository _produtoRepo;
        private Models.Transportador.TransportadorRepository _transportadorRepo;

        public NotaFiscalController(NotaFiscalRepository notaFiscalRepo, PedidoRepository pedidoRepo, ItemPedidoRepository itemPedidoRepo, ItemNotaRepository itemNotaRepo,
            ClienteRepository clienteRepository, ProdutoRepository produtoRepo, TransportadorRepository transportadorRepo)
        {
            _notaRepo = notaFiscalRepo;
            _pedidoRepo = pedidoRepo;
            _itemPedidoRepo = itemPedidoRepo;
            _itemNotaRepo = itemNotaRepo;
            _clienteRepo = clienteRepository;
            _produtoRepo = produtoRepo;
            _transportadorRepo = transportadorRepo;
        }


        public ActionResult Index()
        {
            var model = _notaRepo.ListNotaFiscal();
            return PartialView("Index", model);
        }

        public ActionResult CadastroNotaFiscal(int idPedido)
        {
            var pedido = _pedidoRepo.PedidoById(idPedido);

            if (pedido.NFEmitida == true)
            {
                Response.WriteAsync("<script language='javascript'>alert('NF ja emitida para este pedido')</script>");
                return RedirectToAction("Index", "Pedido");
            }
            else
            {
                var viewModel = new CadastroNotaViewModel();

                viewModel.pedido = pedido;
                viewModel.cliente = _clienteRepo.ClienteById(pedido.IdCliente);
                viewModel.transportador = _transportadorRepo.TransportadorById(pedido.IdTransport);
                viewModel.itens = new List<ItensPedidoItemViewModel>();

                var itens = _itemPedidoRepo.ItemPedidoByPedido(pedido.IdPedido);

                itens.ForEach(i =>
                {
                    viewModel.itens.Add(new ItensPedidoItemViewModel{
                        item = i,
                        produto = _produtoRepo.ProdutoById(i.IdProduto)
                    });;
                });

                viewModel.nota = new NotaFiscal();

                Random random = new Random();
                int randomInt = random.Next(int.MaxValue / 2, int.MaxValue);

                viewModel.nota.Chave = randomInt;
                viewModel.nota.IdPedido = pedido.IdPedido;
                viewModel.nota.NumNF = _notaRepo.GetNextNumNota();
                viewModel.nota.VrFrete = decimal.Parse(string.Format("{0:0.##}", new Random().NextDouble() * 100));
                viewModel.nota.ValorNota = pedido.ValorPedido + viewModel.nota.VrFrete;
                viewModel.nota.QtdeEmbalagens = random.Next(itens.Count, 50);
                viewModel.nota.CNPJEmitente = "78711688000105";

                return PartialView("EmitirNota", viewModel);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastroNotaFiscal(CadastroNotaViewModel vm)
        {
            _notaRepo.IncludeNota(vm.nota);
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

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using Multicarbono.Models.Cliente;
using Multicarbono.Models.ItemPedido;
using Multicarbono.Models.Pedido;
using Multicarbono.Models.Transportador;
using Multicarbono.ViewModels;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;


namespace Multicarbono.Controllers
{
    public class PedidoController : Controller
    {
        private PedidoRepository _pedidoRepo;
        private ClienteRepository _clienteRepo;
        private ItemPedidoRepository _itemPedidoRepo;
        private TransportadorRepository _transportadorRepo;

        public PedidoController(PedidoRepository pedidoRepo, ItemPedidoRepository itemPedidoRepo, ClienteRepository clienteRepo, TransportadorRepository transportadorRepo)
        {
            _pedidoRepo = pedidoRepo;
            _itemPedidoRepo = itemPedidoRepo;
            _clienteRepo = clienteRepo;
            _transportadorRepo = transportadorRepo;
        }


        public ActionResult Index(List<Pedido> model)
        {
            if (model.Count == 0)
                model = _pedidoRepo.ListPedido();
            return PartialView("Index", model);
        }


        public ActionResult CadastroPedido()
        {
            CadastroPedidoViewModel vmPedido = new CadastroPedidoViewModel();
            vmPedido.Clientes = new List<SelectListItem>();
            foreach (Cliente c in _clienteRepo.ListCliente())
            {
                vmPedido.Clientes.Add(new SelectListItem
                {
                    Value = c.CNPJ.ToString(),
                    Text = c.RazaoSocial
                });
            }

            vmPedido.Transportadores = new List<SelectListItem>();
            foreach (Transportador t in _transportadorRepo.ListTransportador())
            {
                vmPedido.Transportadores.Add(new SelectListItem
                {
                    Value = t.IdTransportador.ToString(),
                    Text = t.RazaoSocial
                });
            }

            vmPedido.Usuario = new Configuration.SessionUser();

            vmPedido.Usuario.IdUsuario = int.Parse(HttpContext.Session.GetString("user_id"));
            vmPedido.Usuario.NivelAcesso = (Models.Enum.NivelAcesso)System.Enum.Parse(typeof(Models.Enum.NivelAcesso), HttpContext.Session.GetString("access_grant_type"), true);

            vmPedido.NumPedido = _pedidoRepo.GetNextNumPedido();

            return PartialView("CadastroPedido", vmPedido);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastroPedido(Pedido pedido)
        {
            _pedidoRepo.IncludePedido(pedido);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int idPedido)
        {

            return RedirectToAction("Index", "ItemPedido", new { idPedido = idPedido });
        }


        public ActionResult Edit(int idPedido)
        {
            CadastroPedidoViewModel vmPedido = new CadastroPedidoViewModel();
            
            vmPedido.Clientes = new List<SelectListItem>();
            foreach (Cliente c in _clienteRepo.ListCliente())
            {
                vmPedido.Clientes.Add(new SelectListItem
                {
                    Value = c.CNPJ.ToString(),
                    Text = c.RazaoSocial
                });
            }

            vmPedido.Transportadores = new List<SelectListItem>();
            foreach (Transportador t in _transportadorRepo.ListTransportador())
            {
                vmPedido.Transportadores.Add(new SelectListItem
                {
                    Value = t.IdTransportador.ToString(),
                    Text = t.RazaoSocial
                });
            }


            var model = _pedidoRepo.PedidoById(idPedido);

            vmPedido.Pedido = model;

            return PartialView("AlterarPedido", vmPedido);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int idPedido, Pedido pedido)
        {
    
               _pedidoRepo.UpdatePedido(pedido);
               return RedirectToAction(nameof(Index));

        }

        public ActionResult Delete(int idPedido)
        {
            var model = _pedidoRepo.PedidoById(idPedido);
            return PartialView("/Views/Pedido/modalConfirmDeletePedido.cshtml", model);
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

        public async Task<ActionResult> PedidoByFiltro(string razaoSocial = null, DateTime? dataIni = null, DateTime? dataFim = null)
        {
            var model = _pedidoRepo.PedidoByFiltro(razaoSocial, dataIni, dataFim);
            return PartialView("Index", model);
        }


        public ActionResult ValorPagar(int idPedido, int idCliente, decimal valorPedido)
        {
            decimal saldo = _pedidoRepo.getSaldo(idPedido, idCliente, valorPedido);
            _pedidoRepo.ValorPagar(idPedido, idCliente, valorPedido, saldo);
            
            return RedirectToAction(nameof(Index));
        }


        //public ActionResult MakeFilter(DateTime dataInit, DateTime dataFim, string razaoSocial)
        //{
        //    var model = _pedidoRepo.PedidoById(idPedido);
        //    return PartialView("AlterarPedido", model);

        //    var filters = new List<FilterProp>();

        //    var filterStartDate = FilterProp.Create("startDate", "Value", "DateStart", FilterType.DateTimePick, null);
        //    var filterEndDate = FilterProp.Create("endDate", "Value", "DateEnd", FilterType.DateTimePick, null);
        //    var filterOrder = FilterProp.Create("orderNumber", "Value", "OrderNumber", FilterType.TextBox, null);

        //    filters.Add(filterStartDate);
        //    filters.Add(filterEndDate);
        //    filters.Add(filterOrder);

        //    var filterModel = new FilterModel(filters);
        //    filterModel.ResourcePath = "~/Views/OrderQuery/Index.cshtml";

        //    ViewBag.FilterModel = filterModel;

        //    return filterModel;



        //}
    }
}

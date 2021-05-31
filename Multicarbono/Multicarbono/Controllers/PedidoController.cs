using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Multicarbono.Models.ItemPedido;
using Multicarbono.Models.Pedido;
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
        private ItemPedidoRepository _itemPedidoRepo;

        public PedidoController(PedidoRepository pedidoRepo, ItemPedidoRepository itemPedidoRepo)
        {
            _pedidoRepo = pedidoRepo;
            _itemPedidoRepo = itemPedidoRepo;
        }


        public ActionResult Index(List<Pedido> model)
        {
            if (model.Count == 0)
                model = _pedidoRepo.ListPedido();
            return PartialView("Index", model);
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

        public ActionResult Details(int idPedido)
        {

            return RedirectToAction("Index", "ItemPedido", new { idPedido = idPedido});
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
            return PartialView("/Views/Pedido/modalConfirmDeletePedido", model);
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

        public async Task<ActionResult> PedidoByFiltro(string razaoSocial=null, DateTime? dataIni=null, DateTime? dataFim = null)
        {
            var model = _pedidoRepo.PedidoByFiltro(razaoSocial, dataIni, dataFim);
            return PartialView("Index", model);
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

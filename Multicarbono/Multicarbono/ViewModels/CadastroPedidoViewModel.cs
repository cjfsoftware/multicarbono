using Microsoft.AspNetCore.Mvc.Rendering;
using Multicarbono.Configuration;
using Multicarbono.Models.Pedido;
using System.Collections.Generic;
using System;
using Multicarbono.Models.ItemPedido;

namespace Multicarbono.ViewModels
{
    public class CadastroPedidoViewModel
    {
        public int NumPedido { get; set; }
        public Pedido Pedido { get; set; }
        public SessionUser Usuario { get; set; }
        public List<SelectListItem> Clientes { get; set; }
        public List<SelectListItem> Transportadores { get; set; }
        public List<SelectListItem> Produtos { get; set; }
        public ItemPedido ItemPedido { get; set; }
        public DateTime DtEmissao { get; set; } = DateTime.Now;
    }
}

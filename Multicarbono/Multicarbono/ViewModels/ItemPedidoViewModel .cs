using Microsoft.AspNetCore.Mvc.Rendering;
using Multicarbono.Models.Cliente;
using Multicarbono.Models.ItemPedido;
using Multicarbono.Models.Pedido;
using Multicarbono.Models.Produto;
using Multicarbono.Models.Transportador;
using Multicarbono.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.ViewModels
{
    public class ItemPedidoViewModel
    {
        public ItemPedido ItemPedido { get; set; }
        public List<SelectListItem> Produto { get; set; }
        public Usuario Usuario { get; set; }
        public bool ByFilter { get; set; }
    }
}

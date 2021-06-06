using Microsoft.AspNetCore.Mvc.Rendering;
using Multicarbono.Models.Cliente;
using Multicarbono.Models.Pedido;
using Multicarbono.Models.Transportador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.ViewModels
{
    public class CadastroPedidoViewModel
    {
        public Pedido pedido { get; set; }
        public List<SelectListItem> clientes { get; set; }
        public List<SelectListItem> transportadores { get; set; }
}
}

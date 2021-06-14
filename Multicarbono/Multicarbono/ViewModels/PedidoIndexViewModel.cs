using Microsoft.AspNetCore.Mvc.Rendering;
using Multicarbono.Models.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.ViewModels
{
    public class PedidoIndexViewModel
    {
        public List<PedidoViewModel> Pedidos { get; set; }
        public List<SelectListItem> AllClientes { get; set; }

        public int? IdCliente { get; set; } = null;
        public DateTime? InicioEmissaoCriteria { get; set; } = null;
        public DateTime? FimEmissaoCriteria { get; set; } = null;
        public DateTime? InicioCarregamentoCriteria { get; set; } = null;
        public DateTime? FimCarregamentoCriteria { get; set; } = null;

        public bool ByFilter { get; set; }
    }
}

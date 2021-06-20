using Multicarbono.Models.ItemPedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.ViewModels
{
    public class ItensPedidoViewModel
    {
        public List<ItensPedidoItemViewModel> itens { get; set; }
        public int pedidoId { get; set; }
    }
}

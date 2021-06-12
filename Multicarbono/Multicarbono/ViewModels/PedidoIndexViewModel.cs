using Multicarbono.Models.Cliente;
using Multicarbono.Models.Pedido;
using Multicarbono.Models.Transportador;
using Multicarbono.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.ViewModels
{
    public class PedidoIndexViewModel
    {
        public Pedido Pedido { get; set; }
        public Cliente Cliente { get; set; }
        public Transportador Transportador { get; set; }
        public Usuario Usuario { get; set; }
    }
}

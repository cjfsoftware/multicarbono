using Multicarbono.Models.Cliente;
using Multicarbono.Models.ItemNota;
using Multicarbono.Models.ItemPedido;
using Multicarbono.Models.NotaFiscal;
using Multicarbono.Models.Pedido;
using Multicarbono.Models.Transportador;
using Multicarbono.Models.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.ViewModels
{
    public class NotaViewModel
    {
        public NotaFiscal NotaFiscal { get; set; }
        public List<ItemPedido> ItemPedido { get; set; }
        public List<ItemNota> ItemNota { get; set; }
        public bool ByFilter { get; set; }
    }
}

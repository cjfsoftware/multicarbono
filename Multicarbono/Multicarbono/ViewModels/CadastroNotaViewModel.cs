using Multicarbono.Models.Cliente;
using Multicarbono.Models.NotaFiscal;
using Multicarbono.Models.Pedido;
using Multicarbono.Models.Transportador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.ViewModels
{
    public class CadastroNotaViewModel
    {
        public NotaFiscal nota { get; set; }

        public Pedido pedido { get; set; }

        public Cliente cliente { get; set; }

        public Transportador transportador { get; set; }
        public List<ItensPedidoItemViewModel> itens { get; set; }
    }
}

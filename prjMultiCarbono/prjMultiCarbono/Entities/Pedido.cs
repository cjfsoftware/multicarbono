using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMultiCarbono.Entities
{
    public class Pedido
    {
        public int numPedido { get; set; }
        public string DtEmissao { get; set; }
        public string DtCarregamento { get; set; }
        public string DtAnalise { get; set; }
        public string Observacao { get; set; }
        public string TipoFrete { get; set; }

        public Cliente Cliente { get; set; }

        public List<ItemPedido> ListaItemPedido { get; set; }


    }
}

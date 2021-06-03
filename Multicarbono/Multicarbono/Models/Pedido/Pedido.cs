using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.Pedido
{
    public class Pedido
    {
        public int IdPedido { get; set; }

        public int NumPedido { get; set; }

        public string CNPJCliente { get; set; }

        public int IdUsuario { get; set; }

        public DateTime DtEmissao { get; set; }

        public DateTime DtCarregamento { get; set; }

        public string Obs { get; set; }

        public string TipoFrete { get; set; }

        public decimal ValorPedido { get; set; }

        public DateTime Expedido { get; set; }

        public int IdTransport { get; set; }

        public char NFEmitida { get; set; }
    }
}

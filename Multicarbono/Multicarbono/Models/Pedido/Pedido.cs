using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.Pedido
{
    public class Pedido
    {
        public int IdPedido { get; set; }

        [Display(Name = "Número do pedido")]
        public int NumPedido { get; set; }

        [Display(Name = "CNPJ do Cliente")]
        public string CNPJCliente { get; set; }

        [Display(Name = "Id do Cliente")]
        public int IdUsuario { get; set; }

        [Display(Name = "Data da Emissão")]
        public DateTime DtEmissao { get; set; }

        [Display(Name = "Data de Carregamento")]
        public DateTime DtCarregamento { get; set; }

        [Display(Name = "Observação")]
        public string Obs { get; set; }

        [Display(Name = "Tipo de Frete")]
        public string TipoFrete { get; set; }

        [Display(Name = "Valor do Pedido")]
        public decimal ValorPedido { get; set; }

        [Display(Name = "Data de expedição")]
        public DateTime Expedido { get; set; }

        [Display(Name = "Id do Transportador")]
        public int IdTransport { get; set; }

        public char NFEmitida { get; set; }
    }
}

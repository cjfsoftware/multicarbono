using Multicarbono.Models.Enum;
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

        [Display(Name = "Cliente")]
        public int IdCliente { get; set; }

        [Display(Name = "Usuario")]
        public int IdUsuario { get; set; }

        [Display(Name = "Data da Emissão")]
        public DateTime DtEmissao { get; set; }

        [Display(Name = "Data de Carregamento")]
        [Required]
        public DateTime DtCarregamento { get; set; }

        [Display(Name = "Observação")]
        public string Obs { get; set; }

        [Display(Name = "Tipo de Frete")]
        public TipoFrete TipoFrete { get; set; }

        [Display(Name = "Valor do Pedido")]
        public decimal ValorPedido { get; set; }

        [Display(Name = "Valor a Pagar")]
        public decimal ValorPagar { get; set; }

        [Display(Name = "Data de Expedição")]
        public DateTime Expedido { get; set; }

        [Display(Name = "Id do Transportador")]
        public int IdTransport { get; set; }

        [Display(Name = "Nota Fiscal Emitida")]
        public bool NFEmitida { get; set; }
    }
}

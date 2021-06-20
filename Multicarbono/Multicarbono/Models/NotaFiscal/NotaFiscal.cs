using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.NotaFiscal
{
    public class NotaFiscal
    {
        [Display(Name = "ID")]
        public int IdNF { get; set; }

        [Display(Name = "Número do Pedido")]
        public int IdPedido { get; set; }

        [Display(Name = "Número da Nota Fiscal")]
        public int NumNF { get; set; }

        [Display(Name = "Chave")]
        public int Chave { get; set; }

        [Display(Name = "Natureza da Operação")]
        public string NaturezaOper { get; set; }

        [Display(Name = "Data da Emissão")]
        public DateTime DtEmissao { get; set; }

        [Display(Name = "Data de Saída")]
        public DateTime DtSaida { get; set; }

        [Display(Name = "Valor do Frete")]
        public decimal VrFrete { get; set; }

        [Display(Name = "Quantidade de Embalagens")]
        public int QtdeEmbalagens { get; set; }

        [Display(Name = "CNPJ do Emitente")]
        public string CNPJEmitente { get; set; }

        [Display(Name = "Transmitida")]
        public string Transmitida { get; set; }

        [Display(Name = "Valor da Nota")]
        public decimal ValorNota { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.NotaFiscal
{
    public class NotaFiscal
    {
        public int IdNF { get; set; }

        public int IdPedido { get; set; }

        public int NumNF { get; set; }

        public string Chave { get; set; }

        public string NaturezaOper { get; set; }

        public DateTime DtEmissao { get; set; }

        public DateTime DtSaida { get; set; }

        public decimal VrFrete { get; set; }

        public int QtdeEmbalagens { get; set; }

        public string CNPJEmitente { get; set; }
    }
}

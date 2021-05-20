using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.Produto
{
    public class Produto
    {

        public int IdProduto { get; set; }

        public int CodProduto { get; set; }

        public string Descricao { get; set; }

        public char Ativo { get; set; }

        public int NCM_SH { get; set; }

        public int CST { get; set; }

        public string Unidade { get; set; }

        public decimal VrUnitario { get; set; }

        public decimal Ali_ICMS { get; set; }

        public decimal Ali_IPI { get; set; }

    }
}

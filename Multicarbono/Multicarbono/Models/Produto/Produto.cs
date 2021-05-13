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

        public int Unidade { get; set; }

        public decimal MyProperty { get; set; }

    }
}

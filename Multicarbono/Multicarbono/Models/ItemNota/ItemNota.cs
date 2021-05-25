using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.ItemNota
{
    public class ItemNota
    {
        public int IdItemNF { get; set; }

        public int IdNF { get; set; }

        public int IdItemPedido { get; set; }

        public int CodProduto { get; set; }

        public decimal QtdePesada { get; set; }

        public decimal SubtotalItemNota { get; set; }

    }
}

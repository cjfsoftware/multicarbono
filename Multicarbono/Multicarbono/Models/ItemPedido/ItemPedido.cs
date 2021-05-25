using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.ItemPedido
{
    public class ItemPedido
    {
        public int IdItemPedido { get; set; }

        public int IdPedido { get; set; }

        public int IdProduto { get; set; }

        public int CFOP { get; set; }

        public decimal QTDE { get; set; }

        public decimal SubtotalItemPedido { get; set; }
    }
}

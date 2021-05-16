using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.ItemPedido
{
    public class ItemPedido
    {
        public int ID_ITEM_PEDIDO { get; set; }

        public int ID_PEDIDO { get; set; }

        public int ID_PRODUTO { get; set; }

        public int CFOP { get; set; }

        public decimal QTDE { get; set; }

    }
}

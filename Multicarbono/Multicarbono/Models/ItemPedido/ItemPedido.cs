using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.ItemPedido
{
    public class ItemPedido
    {
        public int IdItemPedido { get; set; }

        public int IdPedido { get; set; }

        [Display(Name = "Produto")]
        public int IdProduto { get; set; }

        public int CFOP { get; set; }

        [Display(Name = "Quantidade")]
        public int QTDE { get; set; }

        [Display(Name = "Subtotal do Item")]
        public decimal SubtotalItemPedido { get; set; }
    }
}

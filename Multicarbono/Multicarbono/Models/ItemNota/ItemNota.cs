using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.ItemNota
{
    public class ItemNota
    {
        public int IdItemNF { get; set; }

        public int IdNF { get; set; }

        public int IdItemPedido { get; set; }

        [Display(Name = "Código do Produto")]
        public int CodProduto { get; set; }

        [Display(Name = "Quantidade Pesada")]
        public decimal QtdePesada { get; set; }

        [Display(Name = "Subtotal do Item")]
        public decimal SubtotalItemNota { get; set; }

        [Display(Name = "Quantidade no Pedido")]
        public decimal QtdePedido { get; set; }
    }
}

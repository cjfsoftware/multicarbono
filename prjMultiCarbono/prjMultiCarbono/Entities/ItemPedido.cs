using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMultiCarbono.Entities
{
    public class ItemPedido
    {
        public int Quantidade { get; set; }
        public float ValorDesconto { get; set; }

        public Produto Produto { get; set; }
    }
}

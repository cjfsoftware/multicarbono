using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMultiCarbono.Entities
{
    public class ItemNota
    {
        public int Codigo { get; set; }
        public int Quantidade { get; set; }
        public string ValorDesconto { get; set; }
        public int Cfop { get; set; }

        public Produto Produto { get; set; }
    }
}

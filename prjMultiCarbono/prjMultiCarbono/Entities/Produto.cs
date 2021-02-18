using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMultiCarbono.Entities
{
    public class Produto
    {
        public int CodProduto { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public string Ncmsh { get; set; }
        public string Cst { get; set; }
        public string Unidade { get; set; }
        public string ValUnitario { get; set; }
        public string AliquotaIcms { get; set; }
        public string AliquotaIpi { get; set; }
    }
}

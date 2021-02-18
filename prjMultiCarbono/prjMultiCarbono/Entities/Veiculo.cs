using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMultiCarbono.Entities
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public string Uf { get; set; }

        public Transportador Transportador { get; set; }
    }
}

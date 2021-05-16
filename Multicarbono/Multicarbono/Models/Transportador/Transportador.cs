using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.Transportador
{
    public class Transportador
    {
        public int IdTransportador { get; set; }

        public string CNPJTransportador { get; set; }

        public string RazaoSocial { get; set; }

        public int IETransportador { get; set; }

        public string EnderecoTransp { get; set; }
    }
}

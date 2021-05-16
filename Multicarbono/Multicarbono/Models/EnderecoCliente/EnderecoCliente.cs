using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.EnderecoCliente
{
    public class EnderecoCliente
    {
        public int IdEndereco { get; set; }

        public int IdCliente { get; set; }

        public string Endereco { get; set; }

        public string CEP { get; set; }

        public char TipoEndereco { get; set; }

    }
}

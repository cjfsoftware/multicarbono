using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.Telefone
{
    public class Telefone
    {
        public int IdTelefone { get; set; }

        public int IdCliente { get; set; }

        public string NumTelefone { get; set; }

        public string Contato { get; set; }

        public string Email { get; set; }
    }
}

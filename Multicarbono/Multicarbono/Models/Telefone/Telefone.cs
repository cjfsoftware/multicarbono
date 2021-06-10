using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.Telefone
{
    public class Telefone
    {
        public int IdTelefone { get; set; }

        public int IdCliente { get; set; }

        [Display(Name = "Número do Telefone")]
        public string NumTelefone { get; set; }

        [Display(Name = "Contato")]
        public string Contato { get; set; }

        public string Email { get; set; }
    }
}

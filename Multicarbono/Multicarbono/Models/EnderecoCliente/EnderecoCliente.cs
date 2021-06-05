using Multicarbono.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.EnderecoCliente
{
    public class EnderecoCliente
    {
        public int IdEndereco { get; set; }

        public int IdCliente { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        public string CEP { get; set; }

        [Display(Name = "Tipo de Endereço")]
        public TipoEnderecoCliente TipoEndereco { get; set; }

    }
}

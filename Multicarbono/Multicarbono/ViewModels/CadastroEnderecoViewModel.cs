using Multicarbono.Models.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.ViewModels
{
    public class CadastroEnderecoViewModel
    {
        public Cliente Cliente { get; set; }
        public Models.EnderecoCliente.EnderecoCliente Endereco { get; set; }
    }
}

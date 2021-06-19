using Multicarbono.Models.Cliente;
using Multicarbono.Models.EnderecoCliente;
using Multicarbono.Models.Telefone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.ViewModels
{
    public class DetalhesClienteViewModel
    {
        public Cliente Cliente { get; set; }
        public List<Telefone> Telefones { get; set; }
        public List<EnderecoCliente> Enderecos { get; set; }

    }
}

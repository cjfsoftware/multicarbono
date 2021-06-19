using Multicarbono.Models.Cliente;
using Multicarbono.Models.Telefone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.ViewModels
{
    public class CadastroTelefoneViewModel
    {
        public Cliente Cliente { get; set; }
        public Telefone Telefone { get; set; }
    }
}
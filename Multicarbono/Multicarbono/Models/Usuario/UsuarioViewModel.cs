using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.Usuario
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel(List<Usuario> usuarios)
        {
            ListUsuarios = usuarios;
        }

        
        public List<Usuario> ListUsuarios { get; set; }


        //public string Nome { get; set; }

        //public DateTime DtNascimento { get; set; }

        //public string Cargo { get; set; }

        //public string Endereco { get; set; }

        //public string Login { get; set; }

        //public string Email { get; set; }

        //public char Status { get; set; }

        //public DateTime DtCriacao { get; set; }

        //public string NivelAcesso { get; set; }

        //public DateTime Senha { get; set; }

    }
}

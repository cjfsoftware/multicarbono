using Multicarbono.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.Usuario
{
    public class Usuario
    {

        public int IdUsuario {get; set;}

        public string Nome { get; set; }

        [Display(Name = "Data de Nascimento")]
        public DateTime DtNascimento { get; set; }

        public string Cargo { get; set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        public string Login { get; set; }

        public string Email { get; set; }

        public bool Ativo { get; set; }

        [Display(Name = "Data de Criação")]
        public DateTime DtCriacao { get; set; }

        [Display(Name = "Nível de Acesso")]
        public NivelAcesso NivelAcesso { get; set; }

        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}

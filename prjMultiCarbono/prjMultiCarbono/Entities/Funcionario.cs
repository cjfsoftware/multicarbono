using prjMultiCarbono.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMultiCarbono.Entities
{
    class Funcionario
    {
        public int Id { get; set; }
        public long Cpf { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public SituacaoCliente SituacaoCliente { get; set; }
        public string Nacionalidade { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Cargo { get; set; }
        public string Regiao { get; set; }
        public DateTime DtCadastro { get; set; }
        public string Situacao { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string Senha { get; set; }

        public IEndereco Endereco { get; set; }
    }
}

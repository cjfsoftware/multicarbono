using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.Cliente
{
    public class Cliente
    {
        public int IdCliente { get; set; }

        public string CNPJ { get; set; }

        public DateTime DtCadastro { get; set; }

        public string RazaoSocial { get; set; }

        public string NomeFantasia { get; set; }

        public string IE { get; set; }

        public char Situacao { get; set; }

        public decimal Saldo { get; set; }

        

    }
}

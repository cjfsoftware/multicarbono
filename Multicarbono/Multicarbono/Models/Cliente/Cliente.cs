using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.Cliente
{
    public class Cliente
    {

        [Display(Name = "ID")]
        public int IdCliente { get; set; }

        public string CNPJ { get; set; }

        [Display(Name = "Data de Cadastro")]
        public DateTime DtCadastro { get; set; }

        [Display(Name = "Razão Social")]
        public string RazaoSocial { get; set; }

        [Display(Name = "Nome Fantasia")]
        public string NomeFantasia { get; set; }

        [Display(Name = "Inscrição Estdadual")]
        public string IE { get; set; }

        [Display(Name = "Situação Cadastral")]
        public char Situacao { get; set; }

        [Display(Name = "Saldo Disponível")]
        public decimal Saldo { get; set; }

        

    }
}

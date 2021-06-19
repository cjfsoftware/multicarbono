using Multicarbono.Models.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace Multicarbono.Models.Cliente
{
    public class Cliente
    {

        [Display(Name = "ID")]
        public int IdCliente { get; set; }

        public string CNPJ { get; set; }

        [Display(Name = "Data de Cadastro")]
        public DateTime DtCadastro { get; set; } = DateTime.Now;

        [Display(Name = "Razão Social")]
        public string RazaoSocial { get; set; }

        [Display(Name = "Nome Fantasia")]
        public string NomeFantasia { get; set; }

        [Display(Name = "Inscrição Estdadual")]
        public string IE { get; set; }

        [Display(Name = "Situação Cadastral")]
        public SituacaoCliente Situacao { get; set; }

        [Display(Name = "Saldo Disponível")]
        public decimal Saldo { get; set; }

        

    }
}

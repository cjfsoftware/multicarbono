using prjMultiCarbono.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMultiCarbono.Entities
{
    public class Cliente
    {

        public int Id { get; set; }
        public long Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string InscricaoEstadual { get; set; }
        public double Saldo { get; set; }
        public SituacaoCliente SitucaoCliente { get; set; }

        public DateTime DataCadastro { get; set; }
        public int PtsMaisVantagem { get; set; }

        public List<Telefone> ListaTelefone { get; set; }
        public Contato Contato { get; set; }
        public List<EnderecoCliente> ListaEnderecoCliente { get; set; }
        public MaisCarbono MaisCarbono { get; set; }
    }
}

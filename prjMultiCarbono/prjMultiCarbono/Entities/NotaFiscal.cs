using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMultiCarbono.Entities
{
    public class NotaFiscal
    {
        public int NumNotaFiscal { get; set; }
        public string ChaveAcesso { get; set; }
        public string NaturezaOperacao { get; set; }
        public string Protocolo { get; set; }
        public string DtEmissao { get; set; }
        public string DtSaida { get; set; }
        public string HoraSaida { get; set; }
        public string ValSeguro { get; set; }
        public string Desconto { get; set; }
        public string Especie { get; set; }
        public string QtdEmbalagens { get; set; }
        public string Numeracao { get; set; }
        public string ValFrete { get; set; }
        public string FretePorConta { get; set; }
        public string Marca { get; set; }

        public List<ItemNota> ListaItemNota { get; set; }

        public Veiculo Veiculo { get; set; }



    }
}

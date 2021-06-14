using Multicarbono.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.Produto
{
    public class Produto
    {

        public int IdProduto { get; set; }

        [Display(Name = "Código do produto")]
        public int CodProduto { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        [Display(Name = "NCM SH")]
        public int NCM_SH { get; set; }

        [Display(Name = "CST")]
        public int CST { get; set; }

        [Display(Name = "Unidade")]
        public TipoUnidadeProduto Unidade { get; set; }

        [Display(Name = "Valor Unitário")]
        public decimal VrUnitario { get; set; }

        [Display(Name = "Aliquota do ICMS")]
        public decimal Ali_ICMS { get; set; }

        [Display(Name = "Aliquota do IPI")]
        public decimal Ali_IPI { get; set; }

    }
}

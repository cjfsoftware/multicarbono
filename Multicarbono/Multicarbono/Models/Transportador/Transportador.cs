using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.Transportador
{
    public class Transportador
    {
        public int IdTransportador { get; set; }

        [Display(Name = "CNPJ")]
        public string CNPJTransportador { get; set; }

        [Display(Name = "Razão Social")]
        public string RazaoSocial { get; set; }

        [Display(Name = "Inscrição Estadual")]
        public int IETransportador { get; set; }

        [Display(Name = "Endereço")]
        public string EnderecoTransp { get; set; }
    }
}

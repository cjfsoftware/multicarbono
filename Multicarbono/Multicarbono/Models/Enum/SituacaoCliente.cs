using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.Enum
{
    public enum SituacaoCliente
    {
        ATIVO,
        INATIVO,

        [Display(Name = "EM PROSPECÇÃO")]
        PROSPECCAO
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMultiCarbono.Entities
{
    public interface IEndereco
    {
        int CodEndereco { get; set; }
        int Cep { get; set; }
        string Logradouro { get; set; }
        int Numero { get; set; } 
        string Cidade { get; set; }
        string Uf { get; set; }
        string Pais { get; set; }
    }
}

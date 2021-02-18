using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMultiCarbono.Entities
{
    public class EnderecoCliente : IEndereco
    {
        public int TipoEndereco { get; set; }
        public IEndereco Endereco { get; set; }
        public int CodEndereco { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Cep { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Logradouro { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Numero { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Cidade { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Uf { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Pais { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

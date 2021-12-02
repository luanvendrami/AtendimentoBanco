using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class EnderecoDoCliente
    {
        public int Id { get; private set; }
        public string Uf { get; private set; }
        public string Cidade { get; private set; }
        public string Bairro { get; private set; }
        public string Rua { get; private set; }
        public string NumeroResidencia { get; private set; }
        public string Complemento { get; private set; }
        public EnderecoDoCliente(string uf, string cidade, string bairro, string rua, string numeroResidencia, string complemento)
        {
            Uf = uf;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            NumeroResidencia = numeroResidencia;
            Complemento = complemento;
        }

        public EnderecoDoCliente()
        {

        }

        public bool Validacao()
        {
            if (!string.IsNullOrEmpty(Uf) && !string.IsNullOrEmpty(Cidade) && !string.IsNullOrEmpty(Bairro) && !string.IsNullOrEmpty(Rua) && !string.IsNullOrEmpty(NumeroResidencia) && !string.IsNullOrEmpty(Complemento))
                return true;
            return false;
        }
    }
}

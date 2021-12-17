using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.ValueObject
{
    public class Endereco : ValueObject
    {
        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Pais { get; private set; }
        public string Cep { get; private set; }

        public Endereco(string rua, string numero, string complemento, string cidade, string estado, string pais, string cep)
        {
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
            Cep = cep;
            ValidaNulo();
        }

        public bool ValidaNulo()
        {
            if (!string.IsNullOrEmpty(Rua) && Rua.Length >= 10 && !string.IsNullOrEmpty(Numero) && !string.IsNullOrEmpty(Complemento) && Complemento.Length >= 3 && !string.IsNullOrEmpty(Cidade) && Cidade.Length >= 5 && !string.IsNullOrEmpty(Estado) && Estado.Length == 2 && !string.IsNullOrEmpty(Pais) && Pais.Length >= 5 && !string.IsNullOrEmpty(Cep) && Cep.Length == 8)
                return true;
            return false;
        }
    }
}

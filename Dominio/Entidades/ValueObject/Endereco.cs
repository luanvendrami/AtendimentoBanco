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
            Rua = ValidaRua(rua);
            Numero = ValidaNumero(numero);
            Complemento = ValidaComplemento(complemento);
            Cidade = ValidaCidade(cidade);
            Estado = ValidaEstado(estado);
            Pais = ValidaPais(pais);
            Cep = ValidaCep(cep);
        }

        public static string ValidaRua(string rua)
        {
            if (string.IsNullOrEmpty(rua) && rua.Length > 10)
                return rua;
            return "Erro ao cadastrar a rua.";
        }

        public static string ValidaNumero(string numero)
        {
            if (string.IsNullOrEmpty(numero))
                return numero;
            return "Erro ao cadastrar o numero.";
                    
        }

        public static string ValidaComplemento(string complemento)
        {
            if (string.IsNullOrEmpty(complemento) && complemento.Length > 3)
                return complemento;
            return "Erro ao cadastrar o complemento.";
        }

        public static string ValidaCidade(string cidade)
        {
            if (string.IsNullOrEmpty(cidade) && cidade.Length > 5)
                return cidade;
            return "Erro ao cadastrar cidade.";
        }

        public static string ValidaEstado(string estado)
        {
            if (string.IsNullOrEmpty(estado) && estado.Length == 2)
                return estado;
            return "Erro ao cadastrar o Estado.";
        }

        public static string ValidaPais(string pais)
        {
            if (string.IsNullOrEmpty(pais) && pais.Length > 5)
                return pais;
            return "Erro ao cadastrar o País.";
        }

        public static string ValidaCep(string cep)
        {
            if (string.IsNullOrEmpty(cep) && cep.Length == 8)
                return cep;
            return "Erro ao cadastrar o Cep.";
        }

    }
}

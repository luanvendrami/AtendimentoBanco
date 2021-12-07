using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string NumeroResidencia { get; set; }
        public string Complemento { get; set; }
        public int IdCliente { get; set; }


        [ForeignKey("IdCliente")]
        public Cliente EnderecoNavegation { get; set; }

        public Endereco(Cliente navegation, string uf, string cidade, string bairro, string rua, string numeroResidencia, string complemento)
        {
            EnderecoNavegation = navegation;
            Uf = uf;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            NumeroResidencia = numeroResidencia;
            Complemento = complemento;
        }

        public Endereco(int idCliente, string uf, string cidade, string bairro, string rua, string numeroResidencia, string complemento)
        {
            IdCliente = idCliente;
            Uf = uf;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            NumeroResidencia = numeroResidencia;
            Complemento = complemento;
        }

        public Endereco()
        {

        }

        public Endereco(string uf, string cidade, string bairro, string rua, string numeroResidencia, string complemento)
        {
            Uf = uf;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            NumeroResidencia = numeroResidencia;
            Complemento = complemento;
        }

        public bool Validacao()
        {
            if (!string.IsNullOrEmpty(Uf) && !string.IsNullOrEmpty(Cidade) && !string.IsNullOrEmpty(Bairro) && !string.IsNullOrEmpty(Rua) && !string.IsNullOrEmpty(NumeroResidencia) && !string.IsNullOrEmpty(Complemento))
                return true;
            return false;
        }
    }
}

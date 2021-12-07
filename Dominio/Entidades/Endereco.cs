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
        public int Id { get; private set; }
        public string Uf { get; private set; }
        public string Cidade { get; private set; }
        public string Bairro { get; private set; }
        public string Rua { get; private set; }
        public string NumeroResidencia { get; private set; }
        public string Complemento { get; private set; }
        public int IdCliente { get; private set; }


        [ForeignKey("IdCliente")]
        public Cliente EnderecoNavegation { get; set; }

        //Construtor usada para o metodo de cadastro de clientes.
        public Endereco(Cliente navegation, string uf, string cidade, string bairro, string rua, string numeroResidencia, string complemento)
        {
            EnderecoNavegation = navegation;
            Uf = uf;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            NumeroResidencia = numeroResidencia;
            Complemento = complemento;
            Validacao();
        }

        //Construtor usada para o metodo atualização de cadastro para clientes.
        public Endereco(int idCliente, string uf, string cidade, string bairro, string rua, string numeroResidencia, string complemento)
        {
            IdCliente = idCliente;
            Uf = uf;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            NumeroResidencia = numeroResidencia;
            Complemento = complemento;
            Validacao();
        }

        public Endereco()
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

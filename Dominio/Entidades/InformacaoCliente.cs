using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class InformacaoCliente
    {

        public int Id { get; private set; }
        public string NomeCompleto { get; private set; }
        public string Cpf { get; private set; }
        public string Rg { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Cep { get; private set; }
        public InformacaoCliente(int id, string nomeCompleto, string cpf, string rg, DateTime dataNascimento, string cep)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
            Cpf = cpf;
            Rg = rg;
            DataNascimento = dataNascimento;
            Cep = cep;
            Validacao();
        }
        public InformacaoCliente()
        {

        }

        public bool Validacao()
        {
            if (!string.IsNullOrEmpty(Id.ToString()) && !string.IsNullOrEmpty(NomeCompleto) && !string.IsNullOrEmpty(Cpf) && !string.IsNullOrEmpty(Rg) && !string.IsNullOrEmpty(DataNascimento.ToString()) && !string.IsNullOrEmpty(Cep))
                return true;
            return false;
        }
    }
}

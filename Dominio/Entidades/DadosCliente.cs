using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class DadosCliente
    {

        public int Id { get; private set; }
        public string NomeCompleto { get; private set; }
        public string Cpf { get; private set; }
        public string Rg { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public DadosCliente(string nomeCompleto, string cpf, string rg, DateTime dataNascimento)
        {
            NomeCompleto = nomeCompleto;
            Cpf = cpf;
            Rg = rg;
            DataNascimento = dataNascimento;
            Validacao();
        }
        public DadosCliente()
        {

        }

        public bool Validacao()
        {
            if (!string.IsNullOrEmpty(NomeCompleto) && !string.IsNullOrEmpty(Cpf) && !string.IsNullOrEmpty(Rg) && !string.IsNullOrEmpty(DataNascimento.ToString()))
                return true;
            return false;
        }
    }
}

using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class DadosCliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Cpf { get;  set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }

#nullable enable
        public virtual PagamentosCliente? Pagamentos { get; set; }
        public virtual EnderecoDoCliente? Endereco { get; set; }
#nullable disable

        public DadosCliente()
        {
 
        }

        public DadosCliente(string nomeCompleto, string cpf, string rg, DateTime dataNascimento, PagamentosCliente pagamentos, EnderecoDoCliente endereco)
        {
            NomeCompleto = nomeCompleto;
            Cpf = cpf;
            Rg = rg;
            DataNascimento = dataNascimento;
            Pagamentos = pagamentos;
            Endereco = endereco;
        }

        public DadosCliente(string nomeCompleto, string cpf, string rg, DateTime dataNascimento)
        {
            NomeCompleto = nomeCompleto;
            Cpf = cpf;
            Rg = rg;
            DataNascimento = dataNascimento;
        }

        public DadosCliente(int id, string nomeCompleto, string cpf, string rg, DateTime dataNascimento)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
            Cpf = cpf;
            Rg = rg;
            DataNascimento = dataNascimento;
        }

        public bool Validacao()
        {
            if (!string.IsNullOrEmpty(NomeCompleto) && !string.IsNullOrEmpty(Cpf) && !string.IsNullOrEmpty(Rg) && !string.IsNullOrEmpty(DataNascimento.ToString()))
                return true;
            return false;
        }
    }
}

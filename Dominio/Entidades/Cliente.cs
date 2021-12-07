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
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Cpf { get;  set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }

#nullable enable
        public virtual Pagamento? Pagamentos { get; set; }
        public virtual Endereco? Endereco { get; set; }
#nullable disable

        public Cliente()
        {
 
        }

        public Cliente(string nomeCompleto, string cpf, string rg, DateTime dataNascimento, Pagamento pagamentos, Endereco endereco)
        {
            NomeCompleto = nomeCompleto;
            Cpf = cpf;
            Rg = rg;
            DataNascimento = dataNascimento;
            Pagamentos = pagamentos;
            Endereco = endereco;
        }

        public Cliente(string nomeCompleto, string cpf, string rg, DateTime dataNascimento)
        {
            NomeCompleto = nomeCompleto;
            Cpf = cpf;
            Rg = rg;
            DataNascimento = dataNascimento;
        }

        public Cliente(int id, string nomeCompleto, string cpf, string rg, DateTime dataNascimento)
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

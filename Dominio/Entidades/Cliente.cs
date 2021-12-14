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
        public int Id { get; private set; }
        public string NomeCompleto { get; private set; }
        public string Cpf { get; private set; }
        public string Rg { get; private set; }
        public DateTime DataNascimento { get; private set; }

#nullable enable
        public virtual Pagamento? Pagamentos { get; set; }
        public virtual Endereco? Endereco { get; set; }
        public virtual Compra? Compra { get; set; }
#nullable disable

        //Construtor usada para o metodo de cadastro de clientes.
        public Cliente(string nomeCompleto, string cpf, string rg, DateTime dataNascimento)
        {
            NomeCompleto = nomeCompleto;
            Cpf = cpf;
            Rg = rg;
            DataNascimento = dataNascimento;
            Validacao();
        }

        //Construtor usada para o metodo atualização de cadastro para clientes.
        public Cliente(int id, string nomeCompleto, string cpf, string rg, DateTime dataNascimento)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
            Cpf = cpf;
            Rg = rg;
            DataNascimento = dataNascimento;
            Validacao();
        }

        public Cliente()
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

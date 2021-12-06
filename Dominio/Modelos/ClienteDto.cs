using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos
{
    public class ClienteDto
    {
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }

        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string NumeroResidencia { get; set; }
        public string Complemento { get; set; }

        public int FormaPagamento { get; set; }
        public bool ConfirmadoPagamento { get; set; }
        public decimal ValorPagamentoAgendado { get; set; }
        public DateTime DataPagamentoAgendado { get; set; }
        public decimal ValorPagamento { get; set; }
        public DateTime DataPagamento { get; set; }
        public decimal ValorMulta { get; set; }
        public decimal ValorDesconto { get; set; }
    }
}

using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Pagamento
    {
        public int Id { get; set; }
        public int FormaPagamento { get; set; }
        public bool ConfirmadoPagamento { get; set; }
        public decimal ValorPagamentoAgendado { get; set; }
        public DateTime DataPagamentoAgendado { get; set; }
        public decimal ValorPagamento { get; set; }
        public DateTime DataPagamento { get; set; }
        public decimal ValorMulta { get; set; }
        public decimal ValorDesconto { get; set; }
        public int IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public virtual Cliente PagamentoNavegation { get; set; }

        //Construtor usada para o metodo de cadastro de clientes.
        public Pagamento(Cliente navegation, TipoPagamento formaPagamento, bool confirmadoPagamento, decimal valorPagamentoAgendado, DateTime dataPagamentoAgendado, decimal valorPagamento, DateTime dataPagamento, decimal valorMulta, decimal valorDesconto)
        {
            PagamentoNavegation = navegation;
            FormaPagamento = (int)formaPagamento;
            ConfirmadoPagamento = confirmadoPagamento;
            ValorPagamentoAgendado = valorPagamentoAgendado;
            DataPagamentoAgendado = dataPagamentoAgendado;
            ValorPagamento = valorPagamento;
            DataPagamento = dataPagamento;
            ValorMulta = valorMulta;
            ValorDesconto = valorDesconto;
            Validacao();
        }

        //Construtor usada para o metodo atualização de cadastro para clientes.
        public Pagamento(int idCliente, TipoPagamento formaPagamento, bool confirmadoPagamento, decimal valorPagamentoAgendado, DateTime dataPagamentoAgendado, decimal valorPagamento, DateTime dataPagamento, decimal valorMulta, decimal valorDesconto)
        {
            IdCliente = idCliente;
            FormaPagamento = (int)formaPagamento;
            ConfirmadoPagamento = confirmadoPagamento;
            ValorPagamentoAgendado = valorPagamentoAgendado;
            DataPagamentoAgendado = dataPagamentoAgendado;
            ValorPagamento = valorPagamento;
            DataPagamento = dataPagamento;
            ValorMulta = valorMulta;
            ValorDesconto = valorDesconto;
            Validacao();
        }

        public Pagamento()
        {

        }

        public bool Validacao()
        {
            if (!string.IsNullOrEmpty(FormaPagamento.ToString()) && !string.IsNullOrEmpty(ConfirmadoPagamento.ToString()) && !string.IsNullOrEmpty(ValorPagamentoAgendado.ToString()) && !string.IsNullOrEmpty(ValorPagamento.ToString()) && !string.IsNullOrEmpty(DataPagamento.ToString()) && !string.IsNullOrEmpty(ValorMulta.ToString()) && !string.IsNullOrEmpty(ValorDesconto.ToString()))
                return true;
            return false;
        }
    }
}

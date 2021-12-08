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
        public int Id { get; private set; }
        public int FormaPagamento { get; private set; }
        public bool ConfirmadoPagamento { get; private set; }
        public decimal ValorPago { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public decimal ValorPagamento { get; private set; }
        public DateTime DataPagamento { get; private set; }
        public decimal Juros { get; private set; }
        public decimal Desconto { get; private set; }
        public int IdCliente { get; private set; }

        [ForeignKey("IdCliente")]
        public virtual Cliente PagamentoNavegation { get; set; }

        //Construtor usada para o metodo de cadastro de clientes.
        public Pagamento(Cliente navegation, TipoPagamento formaPagamento, bool confirmadoPagamento, decimal valorPago, DateTime vencimento, DateTime dataPagamento, decimal juros, decimal desconto, decimal valorPagamento)
        {
            PagamentoNavegation = navegation;
            FormaPagamento = (int)formaPagamento;
            ConfirmadoPagamento = confirmadoPagamento;
            ValorPago = valorPago;
            DataVencimento = vencimento;           
            DataPagamento = dataPagamento;    
            Juros = PagamentoAtrasado(formaPagamento, dataPagamento, vencimento, valorPago, juros);
            Desconto = PagamentoAdiantado(formaPagamento, dataPagamento, vencimento, valorPago, desconto);
            ValorPagamento = ValoresFinais(valorPagamento, Juros, Desconto);      
            Validacao();
        }

        //Construtor usada para o metodo atualização de cadastro para clientes.
        public Pagamento(int idCliente, TipoPagamento formaPagamento, bool confirmadoPagamento, decimal valorPagamentoAgendado, DateTime vencimento, decimal valorPago, DateTime dataPagamento)
        {
            IdCliente = idCliente;
            FormaPagamento = (int)formaPagamento;
            ConfirmadoPagamento = confirmadoPagamento;
            ValorPago = valorPagamentoAgendado;
            DataVencimento = vencimento;
            ValorPagamento = valorPago; 
            DataPagamento = dataPagamento;
            Validacao();
        }

        public Pagamento()
        {

        }

        public bool Validacao()
        {
            if (!string.IsNullOrEmpty(FormaPagamento.ToString()) && !string.IsNullOrEmpty(ConfirmadoPagamento.ToString()) && !string.IsNullOrEmpty(ValorPago.ToString()) && !string.IsNullOrEmpty(ValorPagamento.ToString()) && !string.IsNullOrEmpty(DataPagamento.ToString()))
                return true;
            return false;
        }

        public static decimal PagamentoAtrasado(TipoPagamento formaPagamento, DateTime dataPagamento, DateTime vencimento, decimal valorPago, decimal juros)
        {
            if(dataPagamento > vencimento)
            {
                var data = dataPagamento.Subtract(vencimento).TotalDays;
                double porcentagem; 
                if (data != 0)
                {
                    switch (formaPagamento)
                    {
                        case (TipoPagamento)1: 
                            porcentagem = 0.1 * (double)valorPago;
                            porcentagem *= data;
                            juros = (decimal)porcentagem;
                            return juros;
                        case (TipoPagamento)2:
                            porcentagem = 0.03 * (double)valorPago;
                            porcentagem *= data;
                            juros = (decimal)porcentagem;
                            return juros;
                        case (TipoPagamento)3:
                            porcentagem = 0.03 * (double)valorPago;
                            porcentagem *= data;
                            juros = (decimal)porcentagem;
                            return juros;
                        case (TipoPagamento)4:
                            porcentagem = 0.02 * (double)valorPago;
                            porcentagem *= data;
                            juros = (decimal)porcentagem;
                            return juros;
                        case (TipoPagamento)5:
                            porcentagem = 0.02 * (double)valorPago;
                            porcentagem *= data;
                            juros = (decimal)porcentagem;
                            return juros;                            
                        case (TipoPagamento)6:
                            porcentagem = 0.02 * (double)valorPago;
                            porcentagem *= data;
                            juros = (decimal)porcentagem;
                            return juros;
                    }
                }
                
            }
            return juros; 
        }

        public static decimal PagamentoAdiantado(TipoPagamento formaPagamento, DateTime dataPagamento, DateTime vencimento, decimal valorPago, decimal desconto)
        {
            if(dataPagamento < vencimento)
            {
                var data = vencimento.Subtract(dataPagamento).TotalDays;
                double porcentagem;
                switch (formaPagamento)
                {
                    case (TipoPagamento)1:
                        porcentagem = 0.0001 * (double)valorPago;
                        porcentagem *= data;
                        desconto = (decimal)porcentagem;
                        return desconto;
                    case (TipoPagamento)2:
                        porcentagem = 0.01 * (double)valorPago;
                        porcentagem *= data;
                        desconto = (decimal)porcentagem;
                        return desconto;
                    case (TipoPagamento)3:
                        porcentagem = 0.1 * (double)valorPago;
                        porcentagem *= data;
                        desconto = (decimal)porcentagem;
                        return desconto;
                    case (TipoPagamento)4:
                        porcentagem = 0.1 * (double)valorPago;
                        porcentagem *= data;
                        desconto = (decimal)porcentagem;
                        return desconto;
                    case (TipoPagamento)5:
                        porcentagem = 0.05 * (double)valorPago;
                        porcentagem *= data;
                        desconto = (decimal)porcentagem;
                        return desconto;
                    case (TipoPagamento)6:
                        porcentagem = 0.0001 * (double)valorPago;
                        porcentagem *= data;
                        desconto = (decimal)porcentagem;
                        return desconto;
                }   
            }
            return desconto;
        }

        public static decimal ValoresFinais(decimal valorPagamento, decimal juros, decimal desconto)
        {
            if(juros != 0)
            {
                valorPagamento += juros;
                return valorPagamento;
            }else if(desconto != 0)
            {
                valorPagamento -= desconto;
                return valorPagamento;
            }
            return valorPagamento;
        }
    }
}

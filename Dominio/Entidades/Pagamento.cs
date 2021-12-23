using Dominio.Entidades.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public abstract class Pagamento 
    {
        private List<string> _notificacao;

        public string Numero { get; private set; }
        public DateTime DataPagemento { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPago { get; private set; }
        public string ProprietarioPagamento { get; private set; }
        public Documento Documento { get; private set; }
        public Endereco EnderecoCobranca { get; private set; }
        public Email Email { get; private set; }

        public Pagamento(DateTime dataVencimento, decimal total, decimal totalPago, string proprietarioPagamento, Documento documento, Endereco enderecoCobranca, Email email)
        {
            Numero = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            DataPagemento = DateTime.Now;
            DataVencimento = dataVencimento;
            Total = total;
            TotalPago = totalPago;
            ProprietarioPagamento = proprietarioPagamento;
            Documento = documento;
            EnderecoCobranca = enderecoCobranca;
            Email = email;
        } 

        public string Validar()
        {
            if (string.IsNullOrEmpty(DataVencimento.ToString()))
            {
                _notificacao.Add("Erro na data de vencimento.");
                throw new ArgumentNullException(nameof(DataVencimento));
            }

            if (string.IsNullOrEmpty(Total.ToString()))
            {
                _notificacao.Add("Erro no total inserido.");
                throw new ArgumentNullException(nameof(Total));
            }

            if (string.IsNullOrEmpty(TotalPago.ToString()))
            {
                _notificacao.Add("Erro no total a pagar inserido.");
                throw new ArgumentNullException(nameof(TotalPago));
            }

            if (string.IsNullOrEmpty(ProprietarioPagamento.ToString()))
            {
                _notificacao.Add("Erro ao inserir o Prorprietario do pagamento.");
                throw new ArgumentNullException(nameof(ProprietarioPagamento));
            }

            if (string.IsNullOrEmpty(Documento.ToString()))
            {
                _notificacao.Add("Erro ao inserir o documento.");
                throw new ArgumentNullException(nameof(Documento));
            }

            if (string.IsNullOrEmpty(EnderecoCobranca.ToString()))
            {
                _notificacao.Add("Erro ao inserir o erro de cobrança");
                throw new ArgumentNullException(nameof(EnderecoCobranca));
            }

            if (string.IsNullOrEmpty(Email.ToString()))
            {
                _notificacao.Add("Erro ao inserir o e-mail.");
                throw new ArgumentNullException(nameof(Email));
            }
            return "Todos os campos válidos.";
        }
    }
}

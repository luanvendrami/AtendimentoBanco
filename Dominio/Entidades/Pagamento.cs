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
    }
}

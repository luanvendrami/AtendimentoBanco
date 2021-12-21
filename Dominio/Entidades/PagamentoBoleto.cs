using Dominio.Entidades.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class PagamentoBoleto : Pagamento
    {
        public string CodigoBarra { get; private set; }
        public string NumeroBoleto { get; private set; }
        public PagamentoBoleto(
            string codigoBarra,
            string numeroBoleto,
            DateTime dataPagemento,
            DateTime dataVencimento,
            decimal total,
            decimal totalPago,
            string proprietarioPagamento,
            Documento documento, 
            Endereco enderecoCobranca,
            Email email) : 
            base
            (dataVencimento,
                total,
                totalPago,
                proprietarioPagamento,
                documento,
                enderecoCobranca,
                email)
        {
            CodigoBarra = codigoBarra;
            NumeroBoleto = numeroBoleto;
            AddDescontoBoleto();
        }

        public bool AddDescontoBoleto()
        {
            //decimal valorFinal = 0;
            if(DataVencimento < DataPagemento)
            {
                //var data = DataVencimento.Subtract(DataPagemento).Ticks;
                //valorFinal = Total * data;
                return true;
            }
            return false;
        }

        public bool AddAcrescimoBoleto()
        {
            //decimal valorFinal = 0;
            if (DataVencimento > DataPagemento)
            {
                //var data = DataVencimento.Subtract(DataPagemento).Ticks;
                //valorFinal = Total * data;
                return true;
            }
            return false;
        }
    }
}

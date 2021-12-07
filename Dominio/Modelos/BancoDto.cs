using Dominio.Enums;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dominio.Modelos
{
    public class BancoDto
    {
        //Informações do cliente
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }

        //Informações do endereço do cliente
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string NumeroResidencia { get; set; }
        public string Complemento { get; set; }

        //Informação de pagamento do cliente
        public TipoPagamento FormaPagamento { get; set; }
        public bool ConfirmadoPagamento { get; set; }
        public decimal ValorPagamentoAgendado { get; set; }
        public DateTime DataPagamentoAgendado { get; set; }
        public decimal ValorPagamento { get; set; }
        public DateTime DataPagamento { get; set; }
        public decimal ValorMulta { get; set; }
        public decimal ValorDesconto { get; set; }
    }
}

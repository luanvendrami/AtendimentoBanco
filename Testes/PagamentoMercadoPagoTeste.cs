using Dominio.Entidades;
using Dominio.Entidades.ValueObject;
using Dominio.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes
{
    [TestClass]
    public class PagamentoMercadoPagoTeste
    {
        [TestMethod]
        public void ValidaDescontoMercadoPagoFail()
        {
            var documento = new Documento("Numero", ETipoDocumento.CPF);
            var endereco = new Endereco("Rua", "Numero", "Complemento", "Cidade", "Estado", "Pais", "Cep");
            var email = new Email("Luan.vendrami@hotmail.com");
            var pagamentoMercadoPago = new PagamentoMercadoPago("CodigoTransacao", DateTime.Now, DateTime.Now.AddDays(30), 100, 100, "Proprietario", documento, endereco, email);
            Assert.IsFalse(pagamentoMercadoPago.AddDescontoMercadoPago());
        }

        [TestMethod]
        public void ValidaDescontoMercadoPagoValid()
        {
            var documento = new Documento("Numero", ETipoDocumento.CPF);
            var endereco = new Endereco("Rua", "Numero", "Complemento", "Cidade", "Estado", "Pais", "Cep");
            var email = new Email("Luan.vendrami@hotmail.com");
            var pagamentoMercadoPago = new PagamentoMercadoPago("CodigoTransacao", DateTime.Now, DateTime.Now.AddDays(-2), 100, 100, "Proprietario", documento, endereco, email);
            Assert.IsTrue(pagamentoMercadoPago.AddDescontoMercadoPago());
        }

        [TestMethod]
        public void ValidaAcrescimeoMercadoPagoFail()
        {
            var documento = new Documento("Numero", ETipoDocumento.CPF);
            var endereco = new Endereco("Rua", "Numero", "Complemento", "Cidade", "Estado", "Pais", "Cep");
            var email = new Email("Luan.vendrami@hotmail.com");
            var pagamentoMercadoPago = new PagamentoMercadoPago("CodigoTransacao", DateTime.Now, DateTime.Now.AddDays(2), 100, 100, "Proprietario", documento, endereco, email);
            Assert.IsFalse(pagamentoMercadoPago.AddAcrescimoMercadoPago());
        }

        [TestMethod]
        public void ValidaAcrescimeoMercadopagoValid()
        {
            var documento = new Documento("Numero", ETipoDocumento.CPF);
            var endereco = new Endereco("Rua", "Numero", "Complemento", "Cidade", "Estado", "Pais", "Cep");
            var email = new Email("Luan.vendrami@hotmail.com");
            var pagamentoMercadoPago = new PagamentoMercadoPago("CodigoTransacao", DateTime.Now.AddDays(30), DateTime.Now, 100, 100, "Proprietario", documento, endereco, email);
            Assert.IsTrue(pagamentoMercadoPago.AddAcrescimoMercadoPago());
        }

        [TestMethod]
        public void ValidaCalculoAcrescimoMercadoPagoValid()
        {
            var documento = new Documento("Numero", ETipoDocumento.CPF);
            var endereco = new Endereco("Rua", "Numero", "Complemento", "Cidade", "Estado", "Pais", "Cep");
            var email = new Email("Luan.vendrami@hotmail.com");
            var pagamentoMercadoPago = new PagamentoMercadoPago("CodigoTransacao", DateTime.Now, DateTime.Now.AddDays(3), 300, 100, "Proprietario", documento, endereco, email);
            Assert.AreEqual(354, pagamentoMercadoPago.CalculoAcrescimo());
        }

        [TestMethod]
        public void ValidaCalculoDescontoMercadoPagoValid()
        {
            var documento = new Documento("Numero", ETipoDocumento.CPF);
            var endereco = new Endereco("Rua", "Numero", "Complemento", "Cidade", "Estado", "Pais", "Cep");
            var email = new Email("Luan.vendrami@hotmail.com");
            var pagamentoMercadoPago = new PagamentoMercadoPago("CodigoTransacao", DateTime.Now, DateTime.Now.AddDays(-3), 200, 100, "Proprietario", documento, endereco, email);
            Assert.AreEqual(194, pagamentoMercadoPago.CalculoDesconto());
        }
    }
}

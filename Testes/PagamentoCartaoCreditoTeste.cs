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
    public class PagamentoCartaoCreditoTeste
    {
        [TestMethod]
        public void ValidaDescontoCartaoCreditoFail()
        {
            var documento = new Documento("Numero", ETipoDocumento.CPF);
            var endereco = new Endereco("Rua", "Numero", "Complemento", "Cidade", "Estado", "Pais", "Cep");
            var email = new Email("Luan.vendrami@hotmail.com");
            var pagamentoCartaoCredito = new PagamentoCartaoCredito("NomeCartao", "NumeroCartao","NumeroUltimaTrasacao", DateTime.Now, DateTime.Now.AddDays(30), 100, 100, "Proprietario", documento, endereco, email);
            Assert.IsFalse(pagamentoCartaoCredito.AddDescontoCartaoCredito());
        }

        [TestMethod]
        public void ValidaDescontoCartaoCreditoValid()
        {
            var documento = new Documento("Numero", ETipoDocumento.CPF);
            var endereco = new Endereco("Rua", "Numero", "Complemento", "Cidade", "Estado", "Pais", "Cep");
            var email = new Email("Luan.vendrami@hotmail.com");
            var pagamentoCartaoCredito = new PagamentoCartaoCredito("NomeCartao", "NumeroCartao", "NumeroUltimaTrasacao", DateTime.Now, DateTime.Now.AddDays(-2), 100, 100, "Proprietario", documento, endereco, email);
            Assert.IsTrue(pagamentoCartaoCredito.AddDescontoCartaoCredito());
        }

        [TestMethod]
        public void ValidaAcrescimeoCartaoCreditoFail()
        {
            var documento = new Documento("Numero", ETipoDocumento.CPF);
            var endereco = new Endereco("Rua", "Numero", "Complemento", "Cidade", "Estado", "Pais", "Cep");
            var email = new Email("Luan.vendrami@hotmail.com");
            var pagamentoCartaoCredito = new PagamentoCartaoCredito("NomeCartao", "NumeroCartao", "NumeroUltimaTrasacao", DateTime.Now, DateTime.Now.AddDays(2), 100, 100, "Proprietario", documento, endereco, email);
            Assert.IsFalse(pagamentoCartaoCredito.AddAcrescimoCartaoCredito());
        }

        [TestMethod]
        public void ValidaAcrescimeoCartaoCreditoValid()
        {
            var documento = new Documento("Numero", ETipoDocumento.CPF);
            var endereco = new Endereco("Rua", "Numero", "Complemento", "Cidade", "Estado", "Pais", "Cep");
            var email = new Email("Luan.vendrami@hotmail.com");
            var pagamentoCartaoCredito = new PagamentoCartaoCredito("NomeCartao", "NumeroCartao", "NumeroUltimaTrasacao", DateTime.Now.AddDays(30), DateTime.Now, 100, 100, "Proprietario", documento, endereco, email);
            Assert.IsTrue(pagamentoCartaoCredito.AddAcrescimoCartaoCredito());
        }

        [TestMethod]
        public void ValidaCalculoAcrescimoCartaoCreditoValid()
        {
            var documento = new Documento("Numero", ETipoDocumento.CPF);
            var endereco = new Endereco("Rua", "Numero", "Complemento", "Cidade", "Estado", "Pais", "Cep");
            var email = new Email("Luan.vendrami@hotmail.com");
            var pagamentoCartaoCredito = new PagamentoCartaoCredito("NomeCartao", "NumeroCartao", "NumeroUltimaTrasacao", DateTime.Now, DateTime.Now.AddDays(3), 300, 100, "Proprietario", documento, endereco, email);
            Assert.AreEqual(327, pagamentoCartaoCredito.CalculoAcrescimo());
        }

        [TestMethod]
        public void ValidaCalculoDescontoCartaoCreditoValid()
        {
            var documento = new Documento("Numero", ETipoDocumento.CPF);
            var endereco = new Endereco("Rua", "Numero", "Complemento", "Cidade", "Estado", "Pais", "Cep");
            var email = new Email("Luan.vendrami@hotmail.com");
            var pagamentoCartaoCredito = new PagamentoCartaoCredito("NomeCartao", "NumeroCartao", "NumeroUltimaTrasacao", DateTime.Now, DateTime.Now.AddDays(-3), 200, 100, "Proprietario", documento, endereco, email);
            Assert.AreEqual(182, pagamentoCartaoCredito.CalculoDesconto());
        }
    }
}

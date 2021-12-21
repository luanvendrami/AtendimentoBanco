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
    public class PagamentoBoletoTeste
    {
        [TestMethod]
        public void ValidaDescontoBoletoFail()
        {
            var documento = new Documento("Numero", ETipoDocumento.CPF);
            var endereco = new Endereco("Rua", "Numero", "Complemento", "Cidade", "Estado", "Pais", "Cep");
            var email = new Email("Luan.vendrami@hotmail.com");
            var pagamentoBoleto = new PagamentoBoleto("CodigoBarras", "Numeroboleto", DateTime.Now, DateTime.Now.AddDays(30), 100, 100, "Proprietario", documento, endereco, email);
            Assert.IsFalse(pagamentoBoleto.AddDescontoBoleto());
        }

        [TestMethod]
        public void ValidaDescontoBoletoValid()
        {
            var documento = new Documento("Numero", ETipoDocumento.CPF);
            var endereco = new Endereco("Rua", "Numero", "Complemento", "Cidade", "Estado", "Pais", "Cep");
            var email = new Email("Luan.vendrami@hotmail.com");
            var pagamentoBoleto = new PagamentoBoleto("CodigoBarras", "Numeroboleto", DateTime.Now, DateTime.Now.AddDays(-2), 100, 100, "Proprietario", documento, endereco, email);
            Assert.IsTrue(pagamentoBoleto.AddDescontoBoleto());
        }

        [TestMethod]
        public void ValidaDescontoBoletoFail()
        {
            var documento = new Documento("Numero", ETipoDocumento.CPF);
            var endereco = new Endereco("Rua", "Numero", "Complemento", "Cidade", "Estado", "Pais", "Cep");
            var email = new Email("Luan.vendrami@hotmail.com");
            var pagamentoBoleto = new PagamentoBoleto("CodigoBarras", "Numeroboleto", DateTime.Now, DateTime.Now.AddDays(30), 100, 100, "Proprietario", documento, endereco, email);
            Assert.IsFalse(pagamentoBoleto.AddDescontoBoleto());
        }
    }
}

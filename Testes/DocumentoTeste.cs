using Dominio.Entidades;
using Dominio.Entidades.ValueObject;
using Dominio.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testes
{
    [TestClass]
    public class DocumentoTeste
    {
        [TestMethod]
        public void ValidaCpfFail()
        {
            var doc = new Documento("123", ETipoDocumento.CPF);
            Assert.IsFalse(doc.Validacao());
        }

        [TestMethod]
        public void ValidaCpfValid()
        {
            var doc = new Documento("12345678912", ETipoDocumento.CPF);
            Assert.IsTrue(doc.Validacao());
        }

        [TestMethod]
        public void ValidaCpnjFail()
        {
            var doc = new Documento("123234", ETipoDocumento.CNPJ);
            Assert.IsFalse(doc.Validacao());
        }

        [TestMethod]
        public void ValidaCpnjValid()
        {
            var doc = new Documento("12345678912345", ETipoDocumento.CNPJ);
            Assert.IsTrue(doc.Validacao());
        }

        [TestMethod]
        public void CpfFail()
        {
            var doc = new Documento("00037000999", ETipoDocumento.CPF);
            Assert.IsFalse(doc.ValidaCpf(doc.Numero));
        }

        [TestMethod]
        public void CpfValid()
        {
            var doc = new Documento("116.919.620-90", ETipoDocumento.CPF);
            Assert.IsTrue(doc.ValidaCpf(doc.Numero));
        }
    }
}

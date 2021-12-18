using Dominio.Entidades.ValueObject;
using Dominio.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes.ValueObject
{
    [TestClass]
    public class TelefoneTeste
    {
        [TestMethod]
        public void ValidaTelefoneCelularFail()
        {
            var tel = new Telefone("996605059", ETipoTelefone.CELULAR);
            Assert.IsFalse(tel.ValidaTelefone());
        }

        [TestMethod]
        public void ValidaTelefoneCelularValid()
        {
            var tel = new Telefone("47996605059", ETipoTelefone.CELULAR);
            Assert.IsTrue(tel.ValidaTelefone());
        }

        [TestMethod]
        public void ValidaTelefoneResidencialFail()
        {
            var tel = new Telefone("33841156", ETipoTelefone.RESIDENCIAL);
            Assert.IsFalse(tel.ValidaTelefone());
        }

        [TestMethod]
        public void ValidaTelefoneResidencialValid()
        {
            var tel = new Telefone("4733841156", ETipoTelefone.RESIDENCIAL);
            Assert.IsTrue(tel.ValidaTelefone());
        }
    }
}

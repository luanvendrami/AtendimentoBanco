using Dominio.Entidades.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes
{
    [TestClass]
    public class NameTeste
    {
        [TestMethod]
        public void ValidaNomeFail()
        {
            var end = new Nome("", "say");
            Assert.IsFalse(end.ValidaNulo());
        }

        [TestMethod]
        public void ValidaNomeValid()
        {
            var end = new Nome("Nome", "sobrenome");
            Assert.IsTrue(end.ValidaNulo());
        }
    }
}

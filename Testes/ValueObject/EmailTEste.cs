using Dominio.Entidades.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes.ValueObject
{
    [TestClass]
    public class EmailTeste
    {
        [TestMethod]
        public void ValidaEmailFail()
        {
            var mail = new Email("luan.vendrami");
            Assert.IsFalse(mail.ValidaEmail(mail.Adress));
        }

        [TestMethod]
        public void ValidaEmailValid()
        {
            var mail = new Email("luan.vendrami@hotmail.com");
            Assert.IsTrue(mail.ValidaEmail(mail.Adress));
        }
    }
}

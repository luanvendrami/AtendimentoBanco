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
    public class EnderecoTeste
    {
        [TestMethod]
        public void ValidaEnderecoFail()
        {
            var end = new Endereco("", "numero", "complemento", "cidade", "estado", "pais", "89136000");
            Assert.IsFalse(end.ValidaNulo());
        }

        [TestMethod]
        public void ValidaEnderecoValid()
        {
            var end = new Endereco("Luigui Sardagna", "100", "Casa", "Rodeio", "SC", "Brasil", "12345678");
            Assert.IsTrue(end.ValidaNulo());
        }
    }
}


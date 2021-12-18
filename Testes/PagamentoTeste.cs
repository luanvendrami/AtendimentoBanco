using Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes
{
    [TestClass]
    public class PagamentoTeste
    {

        [TestMethod]
        public void ValidaPagamentoFail()
        {
            var doc = new Pagamento("123", ETipoDocumento.CPF);
            Assert.IsNotNull(doc.Validacao());
        }
    }
}

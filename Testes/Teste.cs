using Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testes
{
    [TestClass]
    public class Teste
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
            var cliente = new Cliente("Luan", "Vendrami", "080", "luan.vendrami@hotmail.com");
        }
    }
}

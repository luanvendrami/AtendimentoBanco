using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class EnderecoCliente
    {
        public int Id { get; private set; }
        public string Uf { get; private set; }
        public string Cidade { get; private set; }
        public string Bairro { get; private set; }
        public string Rua { get; private set; }
        public string NumeroResidencia { get; private set; }
        public string Complemento { get; private set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.ValueObject
{
    public class Email : ValueObject
    {
        public string Adress { get; private set; }
        public Email(string adress)
        {
            Adress = adress;
        }
    }
}

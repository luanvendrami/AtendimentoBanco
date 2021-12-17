using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dominio.Entidades.ValueObject
{
    public class Email : ValueObject
    {
        public string Adress { get; private set; }
        public Email(string adress)
        {
            Adress = adress;
            ValidaEmail(adress);
        }

        public bool ValidaEmail(string emailInformado)
        {
            //Verifica se tem @ e . no e-mail
            if (!emailInformado.Contains("@") || !emailInformado.Contains("."))
                return false;

            //Divide em antes e depois do @
            string[] campos = emailInformado.Split('@');

            //se tiver mais que 1 arroba, não é valido
            if (campos.Length != 2)
                return false;

            //se for menor que 4 caracteres, tá errado
            if (campos[0].Length < 3)
                return false;

            //Agora eu pego depois do arroba e divido os pontos
            if (!campos[1].Contains("."))
                return false;
            campos = campos[1].Split('.');

            //se for menor que 4, é falso
            if (campos[0].Length < 3)
                return false;

            //se chegou aqui, pode ser verdadeiro
            return true;
        }
    }
}

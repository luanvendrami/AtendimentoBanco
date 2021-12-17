using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.ValueObject
{
    public class Email : ValueObject
    {
        public string Adress { get; private set; }
        public Email(string adress)
        {
            Adress = ValidaEmail(adress);
        }

        public static string ValidaEmail(string adress)
        {
            if (!string.IsNullOrEmpty(adress))
                return "Erro ao cadastrar o email.";
            try
            {
                MailAddress email = new(adress);

                return email.ToString();
            }
            catch (FormatException ex)
            {
                return "Erro ao cadastrar o email." + ex.Message;
            }
        }
    }
}

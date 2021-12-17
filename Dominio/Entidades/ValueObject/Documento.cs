using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.ValueObject
{
    public class Documento : ValueObject
    {
        public string Numero { get; private set; }
        public ETipoDocumento Tipo { get; private set; }

        public Documento(string numero, ETipoDocumento tipo)
        {
            Numero = numero;
            Tipo = tipo;
            Validacao();
            ValidaCpf(numero);
        }

        public bool ValidaCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma, resto;
            string tempCpf, digito;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf == null) return false;
            if (cpf.Length != 11) return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++) soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2) resto = 0;
            else resto = 11 - resto;

            digito = resto.ToString();

            tempCpf += digito;

            soma = 0;
            for (int i = 0; i < 10; i++) soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2) resto = 0;
            else resto = 11 - resto;

            digito += resto.ToString();

            return cpf.EndsWith(digito);
        }

        public bool Validacao()
        {
            if (Tipo == ETipoDocumento.CNPJ && Numero.Length == 14)
                return true;

            if (Tipo == ETipoDocumento.CPF && Numero.Length == 11)
                return true;
            return false;
        }
    }
}

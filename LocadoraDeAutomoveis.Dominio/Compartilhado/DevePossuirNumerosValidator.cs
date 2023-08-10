using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.Compartilhado
{
    public class DevePossuirNumerosValidator<T> : PropertyValidator<T, string>
    {
        public override string Name => "DevePossuirNumeros";

        private string nomePropriedade;

        protected override string GetDefaultMessageTemplate(string errorCode)
        {
            return $"'{nomePropriedade}' deve ser composto por letras e números.";
        }

        public override bool IsValid(ValidationContext<T> contextoValidacao, string texto)
        {
            nomePropriedade = contextoValidacao.DisplayName;

            if (string.IsNullOrEmpty(texto))
                return false;

            bool estaValido = true;
            List<int> numeros = NumerosDeUmANove();

            foreach (int numero in numeros)
            {
                foreach (char letra in texto)
                {
                    if (letra == ' ')
                        continue;

                    if (letra == Convert.ToChar(numero))
                    {
                        return estaValido = true;                       
                    }
                }
            }
           



            return estaValido;
        }

        private List<int> NumerosDeUmANove()
        {
            List<int> numeros = new();
            for (int i = 0; i < 10; i++)
            {
                numeros.Add(i);
            }
            return numeros;
        }
    }
}

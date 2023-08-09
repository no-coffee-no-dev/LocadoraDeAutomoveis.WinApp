using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.Compartilhado
{
    public class VerificadorDePlaca<T> : PropertyValidator<T, string>
    {
        public override string Name => "DevePossuirPlacaValida";

        private string nomePropriedade;

        protected override string GetDefaultMessageTemplate(string errorCode)
        {
            return $"'{nomePropriedade}' deve possuir um modelo com letras e numeros.";
        }

        public override bool IsValid(ValidationContext<T> contextoValidacao, string texto)
        {
            nomePropriedade = contextoValidacao.DisplayName;

            if (string.IsNullOrEmpty(texto))
                return false;

            bool estaValido = Regex.IsMatch(texto, "([A-Z]{3}[0-9][0-9A-Z][0-9]{2})|([A-Z]{3}[0-9]{4})");

            return estaValido;
        }
    }
}

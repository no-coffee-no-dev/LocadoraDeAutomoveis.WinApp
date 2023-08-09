using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.Compartilhado
{
    public static class ValidatorExtensions
    {
        public static IRuleBuilderOptions<T, string> DevePossuirNumeros<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new DevePossuirNumerosValidator<T>());
        }
        public static IRuleBuilderOptions<T, string> DevePossuirPlacaValida<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new VerificadorDePlaca<T>());
        }
    }
}

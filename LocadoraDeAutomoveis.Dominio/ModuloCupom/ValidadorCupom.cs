using FluentValidation;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.ModuloCupom
{
    public class ValidadorCupom : AbstractValidator<Cupom>, IValidadorCupom
    {
        public ValidadorCupom()
        {
            RuleFor(x => x.Nome)
              .NotEmpty()
              .NotNull()
              .MinimumLength(3)
              .DevePossuirNumeros();

            RuleFor(x => x.DataDeValidade)
                .NotNull()
                .NotEmpty()
                .Must(x => x > DateTime.UtcNow)
                .WithMessage("A Data deve ser maior que hoje.");

            RuleFor(x => x.Parceiro)
              .NotNull()
              .NotEmpty();


            RuleFor(x => x.Valor)
              .NotNull()
              .NotEmpty()
              .When(p => p.Valor != decimal.Zero && p.Valor > decimal.Zero);

        }
    }
}

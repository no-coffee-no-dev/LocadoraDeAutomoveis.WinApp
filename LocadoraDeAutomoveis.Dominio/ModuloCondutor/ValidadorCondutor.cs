using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.ModuloCondutor
{
    public class ValidadorCondutor : AbstractValidator<Condutor>, IValidadorCondutor
    {
        public ValidadorCondutor()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3);

            RuleFor(x => x.Cliente)
               .NotEmpty()
               .NotNull();
        }
    }
}

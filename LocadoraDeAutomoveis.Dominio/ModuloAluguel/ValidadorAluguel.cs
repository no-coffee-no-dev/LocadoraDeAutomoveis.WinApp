using FluentValidation;
using LocadoraDeAutomoveis.Dominio.ModuloAutomovel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.ModuloAluguel
{
    public class ValidadorAluguel : AbstractValidator<Aluguel>, IValidadorAluguel
    {
        public ValidadorAluguel()
        {
            RuleFor(x => x.ValorFinal)
              .NotEmpty()
              .NotNull();

            RuleFor(x => x.Automovel)
            .NotEmpty()
            .NotNull();

            RuleFor(x => x.Cliente)
           .NotEmpty()
           .NotNull();

            RuleFor(x => x.DataDoAluguel)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Cupom)
              .NotNull();


            RuleFor(x => x.DataDaPrevistaDevolucao)
              .NotNull()
              .NotEmpty();

            RuleFor(x => x.GrupoDeAutomoveis)
              .NotNull()
              .NotEmpty();

        }
    }
}

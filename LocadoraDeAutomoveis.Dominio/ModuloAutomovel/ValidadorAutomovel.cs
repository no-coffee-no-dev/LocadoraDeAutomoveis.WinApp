using FluentValidation;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.ModuloAutomovel
{
    public class ValidadorAutomovel : AbstractValidator<Automovel>, IValidadorAutomovel
    {
        public ValidadorAutomovel()
        {
            RuleFor(x => x.Modelo)
              .NotEmpty()
              .NotNull()
              .MinimumLength(3)
              .DevePossuirNumeros();

            RuleFor(x => x.Placa)
            .NotEmpty()
            .NotNull()
            .MaximumLength(7)
            .DevePossuirPlacaValida();

            RuleFor(x => x.Ano)
           .NotEmpty()
           .NotNull();

            RuleFor(x => x.CapacidadeEmLitros)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.TipoDeCombustivel)
              .NotNull()
              .NotEmpty();


            RuleFor(x => x.Foto)
              .NotNull()
              .NotEmpty()
              .Must(x => x == null || x.Length <= 2697000)
              .WithMessage("Tamanmho maximo permitido de 2mb.");

            RuleFor(x => x.Marca)
              .NotNull()
              .NotEmpty();

        }
    }
}

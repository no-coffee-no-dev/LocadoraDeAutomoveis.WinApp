using FluentValidation;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;

namespace LocadoraDeAutomoveis.Dominio.ModuloPlanoDeCobranca
{
    public class ValidadorPlanoDeCobranca : AbstractValidator<PlanoDeCobranca>, IValidadorPlanoDeCobranca
    {
        public ValidadorPlanoDeCobranca()
        {
            RuleFor(p => p.PrecoDaDiaria)
                .NotEmpty()
                .NotNull();

            RuleFor(p => p.TipoDePlano)
                .NotNull();

        }
    }
}

using FluentValidation;

namespace LocadoraDeAutomoveis.Dominio.ModuloCliente
{
    public class ValidadorCliente : AbstractValidator<Cliente>, IValidadorCliente
    {
        //NaoPodeCaracteresEspeciais
        public ValidadorCliente()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3);
        }
    }
}
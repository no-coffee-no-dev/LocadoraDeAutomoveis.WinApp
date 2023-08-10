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

            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull();
            
            RuleFor(x => x.Telefone)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.Estado)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.Bairro)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.Cidade)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.Rua)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.Numero)
                .NotEmpty()
                .NotNull();
        }
    }
}
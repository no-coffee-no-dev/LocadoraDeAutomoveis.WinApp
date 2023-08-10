using FluentValidation;
using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.ModuloFuncionario
{
    public class ValidadorFuncionario : AbstractValidator<Funcionario>, IValidadorFuncionario
    {
        public ValidadorFuncionario()
        {
            RuleFor(x => x.nome)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3);

            RuleFor(x => x.admissao)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.salario)
                .NotEmpty()
                .NotNull();
               
               
                
        }
    }
}

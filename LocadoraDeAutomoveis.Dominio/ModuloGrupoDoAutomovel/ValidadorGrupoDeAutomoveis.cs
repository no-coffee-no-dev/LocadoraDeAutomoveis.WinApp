using FluentValidation;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel
{
    public class ValidadorGrupoDeAutomoveis : AbstractValidator<GrupoDeAutomoveis>, IValidadorGrupoDeAutomoveis
    {
        public ValidadorGrupoDeAutomoveis()
        {
            RuleFor(x => x.Nome)
              .NotEmpty()
              .NotNull()
              .MinimumLength(3);
            

        }
    }
}

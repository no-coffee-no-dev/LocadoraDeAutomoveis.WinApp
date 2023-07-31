using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.Compartilhado
{
    public interface IValidador<T> where T : EntidadeBase<T>
    {
        public ValidationResult Validate(T instance);
    }
}

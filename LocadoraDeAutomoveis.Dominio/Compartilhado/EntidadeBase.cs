using SequentialGuid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.Compartilhado
{
    public abstract class EntidadeBase<TEntidade>
    {
        public Guid Id { get; set; }

        public EntidadeBase()
        {
            Id = SequentialGuidGenerator.Instance.NewGuid();
        }

        public abstract void Atualizar(TEntidade registro);
    } 
}


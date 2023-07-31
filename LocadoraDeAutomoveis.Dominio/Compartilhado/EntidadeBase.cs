using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.Compartilhado
{
    public abstract class EntidadeBase<TEntidade>
    {
        public int Id { get; set; }
        public abstract void Atualizar(TEntidade registro);
    } 
}


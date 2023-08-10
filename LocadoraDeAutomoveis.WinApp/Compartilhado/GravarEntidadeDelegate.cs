using FluentResults;
using LocadoraDeAutomoveis.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.WinApp.Compartilhado
{
    public delegate Result GravarEntidadeDelegate<TEntidade>(TEntidade registro)
        where TEntidade : EntidadeBase<TEntidade>;

}

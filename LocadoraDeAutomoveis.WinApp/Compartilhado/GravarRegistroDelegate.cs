

using FluentResults;
using LocadoraDeAutomoveis.Dominio.Compartilhado;

namespace LocadoraDeAutomoveis.WinApp.Compartilhado
{
    public delegate Result GravarRegistroDelegate<TEntidade>(TEntidade registro)
        where TEntidade : EntidadeBase<TEntidade>;
}
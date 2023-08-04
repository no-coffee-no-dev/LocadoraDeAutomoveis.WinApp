using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel
{
    public interface IRepositorioGrupoDeAutomoveis : IRepositorio<GrupoDeAutomoveis>
    {
        GrupoDeAutomoveis SelecionarPorNome(string nome);
    }
}

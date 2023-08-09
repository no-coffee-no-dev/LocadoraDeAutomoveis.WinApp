using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.ModuloAutomovel
{
    public interface IRepositorioAutomovel : IRepositorio<Automovel>
    {
        List<Automovel> RetornarCarrosFiltrados(GrupoDeAutomoveis grupoSelecionado);
    }
}

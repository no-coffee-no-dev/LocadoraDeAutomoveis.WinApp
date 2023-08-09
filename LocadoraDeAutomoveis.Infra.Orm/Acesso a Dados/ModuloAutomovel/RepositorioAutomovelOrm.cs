using LocadoraDeAutomoveis.Dominio.ModuloAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.Compartilhado;
using Microsoft.EntityFrameworkCore;

namespace LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloAutomovel
{
    public class RepositorioAutomovelOrm : RepositorioBaseEmOrm<Automovel>, IRepositorioAutomovel
    {
        public RepositorioAutomovelOrm(LocadoraDeAutomoveisDbContext dbContext) : base(dbContext)
        {
        }

        public List<Automovel> RetornarCarrosFiltrados(GrupoDeAutomoveis grupoSelecionado)
        {
            return registros.Include(c => c.GrupoDeAutomoveis).Where(c => c.GrupoDeAutomoveis == grupoSelecionado).ToList();
        }

        public virtual List<Automovel> RetornarTodos()
        {
            return registros.Include(c => c.GrupoDeAutomoveis).ToList();
        }
    }
}

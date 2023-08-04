using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.Compartilhado;

namespace LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloGrupoDoAutomovel
{
    public class RepositorioGrupoDeAutomoveisOrm : RepositorioBaseEmOrm<GrupoDeAutomoveis>, IRepositorioGrupoDeAutomoveis
    {
        public RepositorioGrupoDeAutomoveisOrm(LocadoraDeAutomoveisDbContext dbContext) : base(dbContext)
        {
        }
        public virtual List<GrupoDeAutomoveis> RetornarTodos()
        {
            return registros.ToList();
        }
        public GrupoDeAutomoveis SelecionarPorNome(string nome)
        {
            return registros.FirstOrDefault(x => x.Nome == nome);
        }
    }
}

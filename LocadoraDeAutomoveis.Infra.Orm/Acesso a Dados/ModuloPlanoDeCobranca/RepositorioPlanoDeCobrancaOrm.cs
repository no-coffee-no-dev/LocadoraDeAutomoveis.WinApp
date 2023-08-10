using LocadoraDeAutomoveis.Dominio.ModuloPlanoDeCobranca;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.Compartilhado;
using Microsoft.EntityFrameworkCore;

namespace LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloPlanoDeCobranca
{
    public class RepositorioPlanoDeCobrancaOrm : RepositorioBaseEmOrm<PlanoDeCobranca>, IRepositorioPlanoDeCobranca
    {
        public RepositorioPlanoDeCobrancaOrm(LocadoraDeAutomoveisDbContext dbContext) : base(dbContext)
        {
        }
        public virtual List<PlanoDeCobranca> RetornarTodos()
        {
            return registros.Include(c => c.GrupoDeAutomoveis).ToList();
        }
    }
}

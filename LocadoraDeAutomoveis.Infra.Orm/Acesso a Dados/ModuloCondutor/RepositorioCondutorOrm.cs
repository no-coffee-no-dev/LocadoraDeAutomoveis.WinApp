using LocadoraDeAutomoveis.Dominio.ModuloCondutor;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloCondutor
{
    internal class RepositorioCondutorOrm : RepositorioBaseEmOrm<Condutor>, IRepositorioCondutor
    {
        public RepositorioCondutorOrm(LocadoraDeAutomoveisDbContext dbContext) : base(dbContext)
        {
        }

        public override List<Condutor> RetornarTodos()
        {
            return registros.ToList();
        }
    }
}

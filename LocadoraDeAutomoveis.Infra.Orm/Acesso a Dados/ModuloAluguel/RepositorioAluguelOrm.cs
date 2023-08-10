using LocadoraDeAutomoveis.Dominio.ModuloAluguel;
using LocadoraDeAutomoveis.Dominio.ModuloAutomovel;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.Compartilhado;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloAluguel
{
    public class RepositorioAluguelOrm : RepositorioBaseEmOrm<Aluguel>, IRepositorioAluguel
    {
        public RepositorioAluguelOrm(LocadoraDeAutomoveisDbContext dbContext) : base(dbContext)
        {
        }
        public virtual List<Aluguel> RetornarTodos()
        {
            return registros.Include(c => c.GrupoDeAutomoveis).Include(c => c.Automovel).Include(c => c.Cliente).Include(c => c.Cupom).ToList();
        }
    }  
}

using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using LocadoraDeAutomoveis.Dominio.ModuloFuncionario;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloFuncionario
{
    public class RepositorioFuncionarioOrm : RepositorioBaseEmOrm<Funcionario>, IRepositorioFuncionario
    {
        public RepositorioFuncionarioOrm(LocadoraDeAutomoveisDbContext dbContext) : base(dbContext)
        {
        }
        public virtual List<Funcionario> RetornarTodos()
        {
            return registros.ToList();
        }

      
    }
}

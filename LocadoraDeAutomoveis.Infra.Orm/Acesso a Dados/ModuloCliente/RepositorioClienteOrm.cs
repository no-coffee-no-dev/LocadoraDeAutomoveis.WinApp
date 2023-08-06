using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.Compartilhado;

namespace LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloCliente
{
    public class RepositorioClienteOrm : RepositorioBaseEmOrm<Cliente>, IRepositorioCliente
    {
        public RepositorioClienteOrm(LocadoraDeAutomoveisDbContext dbContext) : base(dbContext)
        {
        }
        public virtual List<Cliente> RetornarTodos()
        {
            return registros.ToList();
        }

        public void CadastrarCliente(Cliente cliente)
        {
            this.Inserir(cliente);
        }
    }
}
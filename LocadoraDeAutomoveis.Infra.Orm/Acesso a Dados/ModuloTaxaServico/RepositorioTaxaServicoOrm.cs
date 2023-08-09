using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using LocadoraDeAutomoveis.Dominio.ModuloTaxaServico;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloTaxaServico
{
    public class RepositorioTaxaServicoOrm : RepositorioBaseEmOrm<TaxaServico>, IRepositorioTaxaServico
    {
        public RepositorioTaxaServicoOrm(LocadoraDeAutomoveisDbContext dbContext) : base(dbContext)
        {
        }
        public virtual List<TaxaServico> RetornarTodos()
        {
            return registros.ToList();
        }

        public void CadastrarCliente(TaxaServico taxaServico)
        {
            this.Inserir(taxaServico);
        }
    }
}

using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.Compartilhado;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloCupom
{
    public class RepositorioCupomOrm : RepositorioBaseEmOrm<Cupom>, IRepositorioCupom
    {
        public RepositorioCupomOrm(LocadoraDeAutomoveisDbContext dbContext) : base(dbContext)
        {
        }
        public virtual List<Cupom> RetornarTodos()
        {
            return registros.Include(c => c.Parceiro).ToList();
        }
        public Cupom SelecionarPorNome(string nome)
        {
            return registros.FirstOrDefault(x => x.Nome == nome);
        }
    }
}

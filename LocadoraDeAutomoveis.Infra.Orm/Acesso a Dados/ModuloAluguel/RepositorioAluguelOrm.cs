﻿using LocadoraDeAutomoveis.Dominio.ModuloAluguel;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.Compartilhado;
using Microsoft.EntityFrameworkCore;

namespace LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloAluguel
{
    public class RepositorioAluguelOrm : RepositorioBaseEmOrm<Aluguel>, IRepositorioAluguel
    {
        public RepositorioAluguelOrm(LocadoraDeAutomoveisDbContext dbContext) : base(dbContext)
        {
        }

        public void Finalizar(Aluguel aluguel)
        {
           aluguel.Concluido = true;
           registros.Update(aluguel);        
        }

        public virtual List<Aluguel> RetornarTodos()
        {
            return registros.Include(c => c.GrupoDeAutomoveis).Include(c => c.Funcionario).Include(c => c.Condutor).Include(c => c.PlanoDeCobranca).Include(c => c.Automovel).Include(c => c.Cliente).Include(c => c.Cupom).Include(c => c.TaxasEServicos).ToList();
        }
    }  
}

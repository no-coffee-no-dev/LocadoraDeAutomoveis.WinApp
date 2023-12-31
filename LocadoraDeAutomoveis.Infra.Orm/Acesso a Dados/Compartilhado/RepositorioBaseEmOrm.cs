﻿using LocadoraDeAutomoveis.Dominio.Compartilhado;
using Microsoft.EntityFrameworkCore;

namespace LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.Compartilhado
{
    public class RepositorioBaseEmOrm<TEntidade> : IRepositorio<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        protected readonly LocadoraDeAutomoveisDbContext dbContext;
        protected DbSet<TEntidade> registros;
        public RepositorioBaseEmOrm(LocadoraDeAutomoveisDbContext dbContext)
        {
            this.dbContext = dbContext;
            registros = dbContext.Set<TEntidade>();
        }

        public void Inserir(TEntidade novaEntidade)
        {
            registros.Add(novaEntidade);
        }

        public void Atualizar(TEntidade entidade)
        {
            registros.Update(entidade);
        }
        public void Deletar(TEntidade entidade)
        {
            registros.Remove(entidade);
        }


        public bool Existe(TEntidade registro)
        {
            return registros.Contains(registro);
        }


        public virtual TEntidade Busca(Guid? id)
        {
            return registros.Find(id);
        }




        public virtual List<TEntidade> RetornarTodos()
        {
            return registros.ToList();
        }
    }
}

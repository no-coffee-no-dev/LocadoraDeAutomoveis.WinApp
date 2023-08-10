﻿using LocadoraDeAutomoveis.Dominio.Compartilhado;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Serilog;
using System.Reflection;

namespace LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.Compartilhado
{
    public class LocadoraDeAutomoveisDbContext : DbContext, IContextoPersistencia
    {
        public LocadoraDeAutomoveisDbContext(DbContextOptions options) : base(options)
        {
        }

        public void DesfazerAlteracoes()
        {
            var registros = ChangeTracker.Entries().Where(x => x.State != EntityState.Unchanged);

            foreach (var registro in registros)
            {
                switch (registro.State)
                {
                    case EntityState.Deleted:
                        {
                            registro.State = EntityState.Unchanged;
                        }
                        break;

                    case EntityState.Modified:
                        {
                            registro.State = EntityState.Unchanged;
                            registro.CurrentValues.SetValues(registro.OriginalValues);
                        }
                        break;

                    case EntityState.Added:
                        {
                            registro.State = EntityState.Detached;
                        }
                        break;

                    default:
                        break;
                }
            }
        } 

        public void GravarDados()
        {
            SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ILoggerFactory loggerFactory = LoggerFactory.Create((x) => 
            {
                x.AddSerilog(Log.Logger);
            });

            optionsBuilder.UseLoggerFactory(loggerFactory);

            optionsBuilder.EnableSensitiveDataLogging();
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            Assembly assembly = typeof(LocadoraDeAutomoveisDbContext).Assembly;

            modelBuilder.ApplyConfigurationsFromAssembly(assembly);

            base.OnModelCreating(modelBuilder);
        }



    }
}

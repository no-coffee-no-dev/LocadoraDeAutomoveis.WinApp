using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.Compartilhado
{
    public class LocadoraDeAutomoveisDesignFactory : IDesignTimeDbContextFactory<LocadoraDeAutomoveisDbContext>
    {
        public LocadoraDeAutomoveisDbContext CreateDbContext(string[] args)
        {
            var configuracao = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var connectionString = configuracao.GetConnectionString("SqlServer");

            var optionsBuilder = new DbContextOptionsBuilder<LocadoraDeAutomoveisDbContext>();

            optionsBuilder.UseSqlServer(connectionString);

            return new LocadoraDeAutomoveisDbContext(optionsBuilder.Options);
        }
    }
}

using FizzWare.NBuilder;
using LocadoraDeAutomoveis.Dominio.ModuloAluguel;
using LocadoraDeAutomoveis.Dominio.ModuloAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using LocadoraDeAutomoveis.Dominio.ModuloPlanoDeCobranca;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.Compartilhado;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloAluguel;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloAutomovel;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloCliente;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloCupom;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloParceiro;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloPlanoDeCobranca;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.TestesIntregacao.Compartilhado
{
    public class TesteDeIntegracaoBase
    {
        protected IRepositorioParceiro repositorioParceiro;
        protected IRepositorioCupom repositorioCupom;
        protected IRepositorioGrupoDeAutomoveis repositorioGrupoDeAutomoveis;
        protected IRepositorioPlanoDeCobranca repositorioPlanoDeCobranca;
        protected IRepositorioAutomovel repositorioAutomovel;
        protected IRepositorioAluguel repositorioAluguel;
        protected IRepositorioCliente repositorioCliente;
        public TesteDeIntegracaoBase()
        {
            LimparTabelas();

            string connectionString = ObterConnectionString();

            var optionsBuilder = new DbContextOptionsBuilder<LocadoraDeAutomoveisDbContext>();

            optionsBuilder.UseSqlServer(connectionString);

            var dbContext = new LocadoraDeAutomoveisDbContext(optionsBuilder.Options);

            repositorioParceiro = new RepositorioParceiroOrm(dbContext);
            repositorioCupom = new RepositorioCupomOrm(dbContext);
            repositorioGrupoDeAutomoveis = new RepositorioGrupoDeAutomoveisOrm(dbContext);
            repositorioPlanoDeCobranca = new RepositorioPlanoDeCobrancaOrm(dbContext);
            repositorioAutomovel = new RepositorioAutomovelOrm(dbContext);
            repositorioAluguel = new RepositorioAluguelOrm(dbContext);
            repositorioCliente = new RepositorioClienteOrm(dbContext);

            BuilderSetup.SetCreatePersistenceMethod<Parceiro>(repositorioParceiro.Inserir);
            BuilderSetup.SetCreatePersistenceMethod<Cupom>(repositorioCupom.Inserir);
            BuilderSetup.SetCreatePersistenceMethod<GrupoDeAutomoveis>(repositorioGrupoDeAutomoveis.Inserir);
            BuilderSetup.SetCreatePersistenceMethod<PlanoDeCobranca>(repositorioPlanoDeCobranca.Inserir);
            BuilderSetup.SetCreatePersistenceMethod<Automovel>(repositorioAutomovel.Inserir);
            BuilderSetup.SetCreatePersistenceMethod<Aluguel>(repositorioAluguel.Inserir);
            BuilderSetup.SetCreatePersistenceMethod<Cliente>(repositorioCliente.Inserir);
        }

        protected static void LimparTabelas()
        {
            string? connectionString = ObterConnectionString();

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string sqlLimpezaTabela =
                @"
                DELETE FROM [DBO].[TBALUGUEL]   
                DELETE FROM [DBO].[TBAUTOMOVEL]
                DELETE FROM [DBO].[TBPLANODECOBRANCA]
                DELETE FROM [DBO].[TBCUPOM]
                DELETE FROM [DBO].[TBGRUPODEAUTOMOVEIS]
                DELETE FROM [DBO].[TBPARCEIRO]
                DELETE FROM [DBO].[TBCLIENTE]
                ;";

            SqlCommand comando = new SqlCommand(sqlLimpezaTabela, sqlConnection);

            sqlConnection.Open();

            comando.ExecuteNonQuery();

            sqlConnection.Close();
        }

        protected static string ObterConnectionString()
        {
            var configuracao = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json")
                .Build();

            var connectionString = configuracao.GetConnectionString("SqlServer");
            return connectionString;
        }
    }
}

﻿using LocadoraDeAutomoveis.Aplicacao.ModuloAluguel;
using LocadoraDeAutomoveis.Aplicacao.ModuloAutomovel;
using LocadoraDeAutomoveis.Aplicacao.ModuloCliente;
using LocadoraDeAutomoveis.Aplicacao.ModuloCupom;
using LocadoraDeAutomoveis.Aplicacao.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.Aplicacao.ModuloParceiro;
using LocadoraDeAutomoveis.Aplicacao.ModuloPlanoDeCobranca;
using LocadoraDeAutomoveis.Dominio.Compartilhado;
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
using LocadoraDeAutomoveis.WinApp.ModuloAluguel;
using LocadoraDeAutomoveis.WinApp.ModuloAutomovel;
using LocadoraDeAutomoveis.WinApp.ModuloCliente;
using LocadoraDeAutomoveis.WinApp.ModuloCupom;
using LocadoraDeAutomoveis.WinApp.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.WinApp.ModuloParceiro;
using LocadoraDeAutomoveis.WinApp.ModuloPlanoDeCobranca;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.WinApp.Compartilhado.IoC
{
    internal class IoC_ComInjecaoDependencia : IoC
    {
        private ServiceProvider container;
        public IoC_ComInjecaoDependencia()
        {
            var configuracao = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appSettings.json")
               .Build();

            var connectionString = configuracao.GetConnectionString("SqlServer");

            var servicos = new ServiceCollection();

            servicos.AddDbContext<IContextoPersistencia, LocadoraDeAutomoveisDbContext>(optionsBuilder =>
            {
                optionsBuilder.UseSqlServer(connectionString);
            });

            servicos.AddTransient<ControladorCupom>();
            servicos.AddTransient<ServicoCupom>();
            servicos.AddTransient<IValidadorCupom, ValidadorCupom>();
            servicos.AddTransient<IRepositorioCupom, RepositorioCupomOrm>();

            servicos.AddTransient<ControladorParceiro>();
            servicos.AddTransient<ServicoParceiro>();
            servicos.AddTransient<IValidadorParceiro, ValidadorParceiro>();
            servicos.AddTransient<IRepositorioParceiro, RepositorioParceiroOrm>();

            servicos.AddTransient<IRepositorioGrupoDeAutomoveis, RepositorioGrupoDeAutomoveisOrm>();
            servicos.AddTransient<IValidadorGrupoDeAutomoveis, ValidadorGrupoDeAutomoveis>();
            servicos.AddTransient<ServicoGrupoDeAutomoveis>();
            servicos.AddTransient<ControladorGrupoDeAutomoveis>();

            servicos.AddTransient<IRepositorioCliente, RepositorioClienteOrm>();
            servicos.AddTransient<IValidadorCliente,ValidadorCliente>();
            servicos.AddTransient<ServicoCliente>();
            servicos.AddTransient<ControladorCliente>();

            servicos.AddTransient<IRepositorioPlanoDeCobranca, RepositorioPlanoDeCobrancaOrm>();
            servicos.AddTransient<IValidadorPlanoDeCobranca, ValidadorPlanoDeCobranca>();
            servicos.AddTransient<ServicoPlanoDeCobranca>();
            servicos.AddTransient<ControladorPlanoDeCobranca>();

            servicos.AddTransient<IRepositorioAutomovel, RepositorioAutomovelOrm>();
            servicos.AddTransient<IValidadorAutomovel, ValidadorAutomovel>();
            servicos.AddTransient<ServicoAutomovel>();
            servicos.AddTransient<ControladorAutomovel>();

            servicos.AddTransient<IRepositorioAluguel, RepositorioAluguelOrm>();
            servicos.AddTransient<IValidadorAluguel, ValidadorAluguel>();
            servicos.AddTransient<ServicoAluguel>();
            servicos.AddTransient<ControladorAluguel>();

            container = servicos.BuildServiceProvider();
        }

        public T Get<T>()
        {
            return container.GetService<T>();
        }
    }
}
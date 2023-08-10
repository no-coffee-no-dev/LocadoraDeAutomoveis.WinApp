using FizzWare.NBuilder;
using FluentAssertions;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.TestesIntregacao.Compartilhado;

namespace LocadoraDeAutomoveis.TestesIntregacao.ModuloGrupoDeAutomoveis
{
    [TestClass]
    public class RepositorioGrupoDeAutomoveisTestes : TesteDeIntegracaoBase
    {
        [TestMethod]
        public void Deve_Inserir_GrupoDeAutomoveis()
        {
            var grupoDeAutomoveis = Builder<GrupoDeAutomoveis>.CreateNew().Build();
            //action
            repositorioGrupoDeAutomoveis.Inserir(grupoDeAutomoveis);
            contextoDePersistencia.GravarDados();
            //assert
            repositorioGrupoDeAutomoveis.Busca(grupoDeAutomoveis.Id).Should().Be(grupoDeAutomoveis);
        }

        [TestMethod]
        public void Deve_editar_GrupoDeAutomoveis()
        {
            //arrange         
            var gpAutomoveisId = Builder<GrupoDeAutomoveis>.CreateNew().Persist().Id;

            var grupoDeAutomoveis = repositorioGrupoDeAutomoveis.Busca(gpAutomoveisId);
            grupoDeAutomoveis.Nome = "CAVALU";

            //action
            repositorioGrupoDeAutomoveis.Atualizar(grupoDeAutomoveis);
            contextoDePersistencia.GravarDados();
            //assert
            repositorioGrupoDeAutomoveis.Busca(grupoDeAutomoveis.Id)
                .Should().Be(grupoDeAutomoveis);
        }
        [TestMethod]
        public void Deve_deletar_GrupoDeAutomoveis()
        {
            //arrange
            var gpAutomoveisId = Builder<GrupoDeAutomoveis>.CreateNew().Persist().Id;
         
            var grupoDeAutomoveis = repositorioGrupoDeAutomoveis.Busca(gpAutomoveisId);

            //action
            repositorioGrupoDeAutomoveis.Deletar(grupoDeAutomoveis);
            contextoDePersistencia.GravarDados();
            //assert
            repositorioGrupoDeAutomoveis.Busca(grupoDeAutomoveis.Id)
                .Should().BeNull();
        }
    }
}

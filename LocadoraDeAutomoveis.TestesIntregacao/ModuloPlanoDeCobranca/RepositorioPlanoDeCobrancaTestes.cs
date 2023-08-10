using FizzWare.NBuilder;
using FluentAssertions;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using LocadoraDeAutomoveis.Dominio.ModuloPlanoDeCobranca;

namespace LocadoraDeAutomoveis.TestesIntregacao.ModuloPlanoDeCobranca
{
    [TestClass]
    public class RepositorioPlanoDeCobrancaTestes : TesteDeIntegracaoBase
    {
        [TestMethod]
        public void Deve_Inserir_PlanoDeCobranca()
        {
            var GrupoDeAutomoveis = Builder<GrupoDeAutomoveis>.CreateNew().Build();
            repositorioGrupoDeAutomoveis.Inserir(GrupoDeAutomoveis);
            var planoDeCobranca = Builder<PlanoDeCobranca>.CreateNew().Build();
            planoDeCobranca.GrupoDeAutomoveis = GrupoDeAutomoveis;

            //action
            repositorioPlanoDeCobranca.Inserir(planoDeCobranca);
            contextoDePersistencia.GravarDados();
            //assert
            repositorioPlanoDeCobranca.Busca(planoDeCobranca.Id).Should().Be(planoDeCobranca);
        }

        [TestMethod]
        public void Deve_editar_PlanoDeCobranca()
        {
            //arrange
            var GrupoDeAutomoveisId = Builder<GrupoDeAutomoveis>.CreateNew().Persist().Id;
            var GrupoDeAutomoveis = repositorioGrupoDeAutomoveis.Busca(GrupoDeAutomoveisId);
            var planoDeCobrancaId = Builder<PlanoDeCobranca>.CreateNew().And(p => p.GrupoDeAutomoveis = GrupoDeAutomoveis).Persist().Id;

            var planoDeCobranca = repositorioPlanoDeCobranca.Busca(planoDeCobrancaId);
            planoDeCobranca.PrecoDaDiaria = 31;

            //action
            repositorioPlanoDeCobranca.Atualizar(planoDeCobranca);
            contextoDePersistencia.GravarDados();
            //assert
            repositorioPlanoDeCobranca.Busca(planoDeCobranca.Id)
                .Should().Be(planoDeCobranca);
        }

        [TestMethod]
        public void Deve_deletar_PlanoDeCobranca()
        {
            //arrange
            var GrupoDeAutomoveisId = Builder<GrupoDeAutomoveis>.CreateNew().Persist().Id;
            var GrupoDeAutomoveis = repositorioGrupoDeAutomoveis.Busca(GrupoDeAutomoveisId);
            var planoDeCobrancaId = Builder<PlanoDeCobranca>.CreateNew().And(p => p.GrupoDeAutomoveis = GrupoDeAutomoveis).Persist().Id;

            var planoDeCobranca = repositorioPlanoDeCobranca.Busca(planoDeCobrancaId);

            //action
            repositorioPlanoDeCobranca.Deletar(planoDeCobranca);
            contextoDePersistencia.GravarDados();
            //assert
            repositorioCupom.Busca(planoDeCobranca.Id)
                .Should().BeNull();
        }
    }
}

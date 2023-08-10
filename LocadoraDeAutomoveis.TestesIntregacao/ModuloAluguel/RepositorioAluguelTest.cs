using FizzWare.NBuilder;
using FluentAssertions;
using LocadoraDeAutomoveis.Dominio.ModuloAluguel;
using LocadoraDeAutomoveis.Dominio.ModuloAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using LocadoraDeAutomoveis.Dominio.ModuloPlanoDeCobranca;

namespace LocadoraDeAutomoveis.TestesIntregacao.ModuloAluguel
{
    [TestClass]
    public class RepositorioAluguelTest : TesteDeIntegracaoBase
    {
        [TestMethod]
        public void Deve_Inserir_Aluguel()
        {
            var aluguel = Builder<Aluguel>.CreateNew().Build();

            var grupoDeAutomovel = Builder<GrupoDeAutomoveis>.CreateNew().Build();
            repositorioGrupoDeAutomoveis.Inserir(grupoDeAutomovel);

            var automovel = Builder<Automovel>.CreateNew().Build();
            automovel.GrupoDeAutomoveis = grupoDeAutomovel;
            automovel.Foto = new byte[1];

            var planoDeCobranca = Builder<PlanoDeCobranca>.CreateNew().Build();
            planoDeCobranca.GrupoDeAutomoveis = grupoDeAutomovel;

            automovel.GrupoDeAutomoveis = grupoDeAutomovel;
            automovel.Foto = new byte[1];

            var parceiro = Builder<Parceiro>.CreateNew().Build();
            repositorioParceiro.Inserir(parceiro);

            var cupom = Builder<Cupom>.CreateNew().Build();
            cupom.Parceiro = parceiro;

            var cliente = Builder<Cliente>.CreateNew().Build();
            repositorioCliente.Inserir(cliente);

            aluguel.GrupoDeAutomoveis = grupoDeAutomovel;
            aluguel.Automovel = automovel;
            aluguel.PlanoDeCobranca = planoDeCobranca;
            aluguel.Cupom = cupom;
            aluguel.Cliente = cliente;

            //action
            repositorioAluguel.Inserir(aluguel);

            //assert
            repositorioAluguel.Busca(aluguel.Id).Should().Be(aluguel);
        }

        [TestMethod]
        public void Deve_editar_Aluguel()
        {
            //arrange
            var grupoDeAutomovelId = Builder<GrupoDeAutomoveis>.CreateNew().Persist().Id;
            var grupoDeAutomovel = repositorioGrupoDeAutomoveis.Busca(grupoDeAutomovelId);

            var automovelId = Builder<Automovel>.CreateNew().And(c => c.Foto = new byte[1]).And(c => c.GrupoDeAutomoveis = grupoDeAutomovel).Persist().Id;
            var automovel = repositorioAutomovel.Busca(automovelId);

            var planoDeCobrancaId = Builder<PlanoDeCobranca>.CreateNew().And(p => p.GrupoDeAutomoveis = grupoDeAutomovel).Persist().Id;
            var planoDeCobranca = repositorioPlanoDeCobranca.Busca(planoDeCobrancaId);

            var parceiroId = Builder<Parceiro>.CreateNew().Persist().Id;
            var parceiro = repositorioParceiro.Busca(parceiroId);

            var cupomId = Builder<Cupom>.CreateNew().And(c => c.Parceiro = parceiro).Persist().Id;
            var cupom = repositorioCupom.Busca(cupomId);

            var clienteId = Builder<Cliente>.CreateNew().Persist().Id;
            var cliente = repositorioCliente.Busca(clienteId);

            var aluguelId = Builder<Aluguel>.CreateNew()
            .And(a => a.Automovel = automovel)
            .And(a => a.PlanoDeCobranca = planoDeCobranca)
            .And(a => a.Cupom = cupom)
            .And(a => a.GrupoDeAutomoveis = grupoDeAutomovel)
            .And(a => a.Cliente = cliente).Persist().Id;

            var aluguel = repositorioAluguel.Busca(aluguelId);
            aluguel.ValorFinal = 100;
            //action
            repositorioAluguel.Atualizar(aluguel);

            //assert
            repositorioAluguel.Busca(aluguel.Id)
                .Should().Be(aluguel);
        }

        [TestMethod]
        public void Deve_deletar_Aluguel()
        {
            //arrange
            var grupoDeAutomovelId = Builder<GrupoDeAutomoveis>.CreateNew().Persist().Id;
            var grupoDeAutomovel = repositorioGrupoDeAutomoveis.Busca(grupoDeAutomovelId);

            var automovelId = Builder<Automovel>.CreateNew().And(c => c.Foto = new byte[1]).And(c => c.GrupoDeAutomoveis = grupoDeAutomovel).Persist().Id;
            var automovel = repositorioAutomovel.Busca(automovelId);

            var planoDeCobrancaId = Builder<PlanoDeCobranca>.CreateNew().And(p => p.GrupoDeAutomoveis = grupoDeAutomovel).Persist().Id;
            var planoDeCobranca = repositorioPlanoDeCobranca.Busca(planoDeCobrancaId);

            var parceiroId = Builder<Parceiro>.CreateNew().Persist().Id;
            var parceiro = repositorioParceiro.Busca(parceiroId);

            var cupomId = Builder<Cupom>.CreateNew().And(c => c.Parceiro = parceiro).Persist().Id;
            var cupom = repositorioCupom.Busca(cupomId);

            var clienteId = Builder<Cliente>.CreateNew().Persist().Id;
            var cliente = repositorioCliente.Busca(clienteId);

            var aluguelId = Builder<Aluguel>.CreateNew()
            .And(a => a.Automovel = automovel)
            .And(a => a.PlanoDeCobranca = planoDeCobranca)
            .And(a => a.Cupom = cupom)
            .And(a => a.GrupoDeAutomoveis = grupoDeAutomovel)
            .And(a => a.Cliente = cliente).Persist().Id;

            var aluguel = repositorioAluguel.Busca(aluguelId);

            //action
            repositorioAluguel.Deletar(aluguel);

            //assert
            repositorioAluguel.Busca(aluguel.Id)
                .Should().BeNull();
        }
    }
}

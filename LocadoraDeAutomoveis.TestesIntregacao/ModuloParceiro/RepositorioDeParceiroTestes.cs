using FizzWare.NBuilder;
using FluentAssertions;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using LocadoraDeAutomoveis.TestesIntregacao.Compartilhado;

namespace LocadoraDeAutomoveis.TestesIntregacao
{
    [TestClass]
    public class RepositorioDeParceiroTestes : TesteDeIntegracaoBase
    {
        [TestMethod]
        public void Deve_Inserir_Parceiro()
        {
            var parceiro = Builder<Parceiro>.CreateNew().Build();

            //action
            repositorioParceiro.Inserir(parceiro);

            //assert
            repositorioParceiro.Busca(parceiro.Id).Should().Be(parceiro);
        }

        [TestMethod]
        public void Deve_editar_Parceiro()
        {
            //arrange
            var disciplinaId = Builder<Parceiro>.CreateNew().Persist().Id;

            var disciplina = repositorioParceiro.Busca(disciplinaId);
            disciplina.Nome = "História";

            //action
            repositorioParceiro.Atualizar(disciplina);

            //assert
            repositorioParceiro.Busca(disciplina.Id)
                .Should().Be(disciplina);
        }
        [TestMethod]
        public void Deve_deletar_Parceiro()
        {
            //arrange
            var disciplinaId = Builder<Parceiro>.CreateNew().Persist().Id;

            var disciplina = repositorioParceiro.Busca(disciplinaId);
            disciplina.Nome = "História";

            //action
            repositorioParceiro.Deletar(disciplina);

            //assert
            repositorioParceiro.Busca(disciplina.Id)
                .Should().BeNull();
        }
    }
}
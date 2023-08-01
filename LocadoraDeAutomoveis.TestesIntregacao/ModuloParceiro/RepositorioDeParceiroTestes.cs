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
    }
}
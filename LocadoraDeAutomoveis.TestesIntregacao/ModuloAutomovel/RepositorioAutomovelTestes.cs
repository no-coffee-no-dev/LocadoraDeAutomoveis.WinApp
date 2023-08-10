using FizzWare.NBuilder;
using FluentAssertions;
using LocadoraDeAutomoveis.Dominio.ModuloAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;

namespace LocadoraDeAutomoveis.TestesIntregacao.ModuloAutomovel
{
    [TestClass]
    public class RepositorioAutomovelTestes : TesteDeIntegracaoBase
    {
        [TestMethod]
        public void Deve_Inserir_Automovel()
        {
            var automovel = Builder<Automovel>.CreateNew().Build();           
            var grupoDeAutomovel = Builder<GrupoDeAutomoveis>.CreateNew().Build();
            repositorioGrupoDeAutomoveis.Inserir(grupoDeAutomovel);

            automovel.GrupoDeAutomoveis = grupoDeAutomovel;
            automovel.Foto = new byte[1];
            
            //action
            repositorioAutomovel.Inserir(automovel);
            contextoDePersistencia.GravarDados();
            //assert
            repositorioAutomovel.Busca(automovel.Id).Should().Be(automovel);
        }

        [TestMethod]
        public void Deve_editar_Automovel()
        {
            //arrange
            var grupoDeAutomovelId = Builder<GrupoDeAutomoveis>.CreateNew().Persist().Id;
            var grupoDeAutomovel = repositorioGrupoDeAutomoveis.Busca(grupoDeAutomovelId);
            var automovelId = Builder<Automovel>.CreateNew().And(c => c.Foto = new byte[1]).And(c => c.GrupoDeAutomoveis = grupoDeAutomovel).Persist().Id;          

            var automovel = repositorioAutomovel.Busca(automovelId);
            automovel.Marca = "UF100";

            //action
            repositorioAutomovel.Atualizar(automovel);
            contextoDePersistencia.GravarDados();
            //assert
            repositorioAutomovel.Busca(automovel.Id)
                .Should().Be(automovel);
        }
        [TestMethod]
        public void Deve_deletar_Automovel()
        {
            //arrange
            var grupoDeAutomovelId = Builder<GrupoDeAutomoveis>.CreateNew().Persist().Id;
            var grupoDeAutomovel = repositorioGrupoDeAutomoveis.Busca(grupoDeAutomovelId);
            var automovelId = Builder<Automovel>.CreateNew().And(c => c.Foto = new byte[1]).And(c => c.GrupoDeAutomoveis = grupoDeAutomovel).Persist().Id;

            var automovel = repositorioAutomovel.Busca(automovelId);

            //action
            repositorioAutomovel.Deletar(automovel);
            contextoDePersistencia.GravarDados();
            //assert
            repositorioAutomovel.Busca(automovel.Id)
                .Should().BeNull();
        }

    }
  
}

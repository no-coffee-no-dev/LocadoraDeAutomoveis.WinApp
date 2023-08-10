using FizzWare.NBuilder;
using FluentAssertions;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using LocadoraDeAutomoveis.Infra.Orm.Migrations;
using LocadoraDeAutomoveis.TestesIntregacao.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.TestesIntregacao.ModuloCupom
{
    [TestClass]
    public class RepositorioCupomTestes : TesteDeIntegracaoBase
    {
            
        [TestMethod]
        public void Deve_Inserir_Cupom()
        {
            var parceiro = Builder<Parceiro>.CreateNew().Build();
            repositorioParceiro.Inserir(parceiro);
            var cupom = Builder<Cupom>.CreateNew().Build();
            cupom.Parceiro = parceiro;

            //action
            repositorioCupom.Inserir(cupom);
            contextoDePersistencia.GravarDados();
            //assert
            repositorioCupom.Busca(cupom.Id).Should().Be(cupom);
        }

        [TestMethod]
        public void Deve_editar_Cupom()
         {
            //arrange
            var parceiroId = Builder<Parceiro>.CreateNew().Persist().Id;
            var parceiro = repositorioParceiro.Busca(parceiroId);
            var cupomId = Builder<Cupom>.CreateNew().And(c => c.Parceiro = parceiro).Persist().Id;

            var cupom = repositorioCupom.Busca(cupomId);
            cupom.Nome = "UF100";

            //action
            repositorioCupom.Atualizar(cupom);
            contextoDePersistencia.GravarDados();
            //assert
            repositorioCupom.Busca(cupom.Id)
                .Should().Be(cupom);
        }
        [TestMethod]
        public void Deve_deletar_Cupom()
        {
            //arrange
            var parceiroId = Builder<Parceiro>.CreateNew().Persist().Id;
            var parceiro = repositorioParceiro.Busca(parceiroId);
            var cupomId = Builder<Cupom>.CreateNew().And(c => c.Parceiro = parceiro).Persist().Id;

            var cupom = repositorioCupom.Busca(cupomId);

            //action
            repositorioCupom.Deletar(cupom);
            contextoDePersistencia.GravarDados();
            //assert
            repositorioCupom.Busca(cupom.Id)
                .Should().BeNull();
        }
    }
}

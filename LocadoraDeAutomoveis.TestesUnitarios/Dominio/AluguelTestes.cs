using FluentAssertions;
using LocadoraDeAutomoveis.Dominio.ModuloAluguel;
using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.TestesUnitarios.Dominio
{
    [TestClass]
    public class AluguelTestes
    {
        Parceiro parceiro;
        Cupom cupom;
        Aluguel aluguel;
        public AluguelTestes()
        {
            parceiro = new();
            parceiro.Nome = "www";


            cupom = new();
            cupom.Nome = "d";
            cupom.DataDeValidade = Convert.ToDateTime("12/12/12");
            cupom.Valor = 100;
            cupom.Parceiro = parceiro;

            aluguel = new();
            aluguel.Cupom = cupom;
        }


        [TestMethod]
        public void Deve_Calcular_O_Preco_Com_Desconto_Do_Cupom()
        {
            aluguel.ValorFinal = 1000;
            //Ação -- Action
            decimal precoComDesconto = aluguel.CalcularValorComCupom();

            //Verificação -- Assert            
            precoComDesconto.Should().Be(900);
        }
    }
}

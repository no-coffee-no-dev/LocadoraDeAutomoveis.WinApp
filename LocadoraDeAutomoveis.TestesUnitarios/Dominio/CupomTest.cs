using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace LocadoraDeAutomoveis.TestesUnitarios.Dominio
{
    [TestClass]
    public class CupomTest
    {
        Cupom cupom;
        Parceiro parceiro;
        public CupomTest()
        {
            parceiro = new();
            parceiro.Nome = "www";


            cupom = new();
            cupom.Nome = "d";
            cupom.DataDeValidade = Convert.ToDateTime("12/12/12");
            cupom.Valor = 23;
            cupom.Parceiro = parceiro;
        }

        [TestMethod]
        public void Deve_Expirar_cupons_fora_do_prazo()
        {
            //Ação -- Action
            cupom.Expirou();
            bool expirou = cupom.Expirado;

            //Verificação -- Assert            
            expirou.Should().Be(true);
        }
    }
}

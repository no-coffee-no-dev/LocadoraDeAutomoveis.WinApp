using FluentAssertions;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloPlanoDeCobranca;

namespace LocadoraDeAutomoveis.TestesUnitarios.Dominio
{
    [TestClass]
    public class PlanoDeCobrancaTest
    {
        PlanoDeCobranca planoDeCobranca;
        GrupoDeAutomoveis grupoDeAutomoveis;
        public PlanoDeCobrancaTest()
        {
            grupoDeAutomoveis = new();
            grupoDeAutomoveis.Nome = "CarsBitch";


            planoDeCobranca = new();
            planoDeCobranca.PrecoDaDiaria = 100;
            planoDeCobranca.KmDisponiveis = 1;
            planoDeCobranca.PrecoPorKM = 23;
            planoDeCobranca.GrupoDeAutomoveis = grupoDeAutomoveis;
        }

        [TestMethod]
        public void Deve_Calcular_o_preco_total_das_diarias()
        {
            DateTime dataDeDevolucao = DateTime.UtcNow.AddDays(2);
            //Ação -- Action

            decimal precoDoPlano = planoDeCobranca.CalcularPrecoTotalDasDiarias(dataDeDevolucao);

            //Verificação -- Assert            
            precoDoPlano.Should().Be(200);
        }
    }
}

using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Dominio.ModuloPlanoDeCobranca
{
    public class PlanoDeCobranca : EntidadeBase<PlanoDeCobranca>
    {
        public GrupoDeAutomoveis GrupoDeAutomoveis { get; set; }
        public decimal PrecoDaDiaria { get; set; }
        public decimal? PrecoPorKM{ get; set; }
        public decimal? KmDisponiveis { get; set; }
        public TipoDePlanoEnum TipoDePlano { get; set; }

        public PlanoDeCobranca()
        {

        }
        public PlanoDeCobranca(Guid id) : this()
        {
            Id = id;
        }

        public PlanoDeCobranca(GrupoDeAutomoveis grupoDeAutomoveis, decimal precoDaDiaria, decimal? precoPorKM, decimal? kmDisponiveis, TipoDePlanoEnum tipoDePlano)
        {
            GrupoDeAutomoveis = grupoDeAutomoveis;
            PrecoDaDiaria = precoDaDiaria;
            PrecoPorKM = precoPorKM;
            KmDisponiveis = kmDisponiveis;
            TipoDePlano = tipoDePlano;
        }

        public override void Atualizar(PlanoDeCobranca registro)
        {
            GrupoDeAutomoveis = registro.GrupoDeAutomoveis;
            PrecoDaDiaria = registro.PrecoDaDiaria;
            PrecoPorKM = registro.PrecoPorKM;
            KmDisponiveis = registro.KmDisponiveis;
            TipoDePlano = registro.TipoDePlano;
        }
        public decimal? CalcularPrecoFinal(DateTime dataDaDevolucao, decimal? kmsRodados)
        {
            if(TipoDePlano == TipoDePlanoEnum.PlanoDiario)
            {
               decimal precoDasDiarias = CalcularPrecoTotalDasDiarias(dataDaDevolucao);
               decimal? precoDosKms = CalcularPrecoTotalDosKmsRodados(kmsRodados);
               return precoDasDiarias + precoDosKms;

            }
            if (TipoDePlano == TipoDePlanoEnum.PlanoControlado)
            {
                decimal? precoDosKms = 0;
                decimal precoDasDiarias = CalcularPrecoTotalDasDiarias(dataDaDevolucao);
                decimal? kmsExtrapolados = KmDisponiveis - kmsRodados;
                if(KmDisponiveis > kmsRodados)
                    precoDosKms = CalcularPrecoTotalDosKmsRodados(kmsExtrapolados);
                return precoDasDiarias + precoDosKms;
            }
            if (TipoDePlano == TipoDePlanoEnum.PlanoKMLivre)
            {
                decimal precoDasDiarias = CalcularPrecoTotalDasDiarias(dataDaDevolucao);
                return precoDasDiarias;
            }
            return null;
        }
        public decimal CalcularPrecoTotalDasDiarias(DateTime dataDaDevolucao)
        {
            int dias = dataDaDevolucao.DayOfYear - DateTime.UtcNow.DayOfYear;
            return PrecoDaDiaria * dias;
        }
        public decimal? CalcularPrecoTotalDosKmsRodados(decimal? kmsRodados)
        {
            return PrecoPorKM * kmsRodados;
        }

        public override string? ToString()
        {
            return $"{GrupoDeAutomoveis}, Diarias de R${PrecoDaDiaria}";
        }
    }
}

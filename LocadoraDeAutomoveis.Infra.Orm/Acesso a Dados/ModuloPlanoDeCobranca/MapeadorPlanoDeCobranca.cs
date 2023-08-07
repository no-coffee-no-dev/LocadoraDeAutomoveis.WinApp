using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocadoraDeAutomoveis.Dominio.ModuloPlanoDeCobranca;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;

namespace LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloPlanoDeCobranca
{
    public class MapeadorPlanoDeCobranca :IEntityTypeConfiguration<PlanoDeCobranca>
    {
        public void Configure(EntityTypeBuilder<PlanoDeCobranca> planoDeCobrancaBuilder)
        {
            
            planoDeCobrancaBuilder.ToTable("TBPlanoDeCobranca");

            planoDeCobrancaBuilder.Property(p => p.Id).IsRequired().ValueGeneratedNever();
            planoDeCobrancaBuilder.Property(p => p.PrecoDaDiaria).HasColumnType("decimal(18,0)").IsRequired();
            planoDeCobrancaBuilder.Property(p => p.KmDisponiveis).HasColumnType("decimal(18,0)");
            planoDeCobrancaBuilder.Property(p => p.PrecoPorKM).HasColumnType("decimal(18,0)");
            planoDeCobrancaBuilder.Property(p => p.TipoDePlano).HasConversion<int>().IsRequired(); ;

            planoDeCobrancaBuilder.HasOne(p => p.GrupoDeAutomoveis)
               .WithMany()
               .IsRequired()
               .HasConstraintName("FK_TBPlanoDeCobranca_TBGrupoDeAutomoveis")
               .OnDelete(DeleteBehavior.NoAction);

        }
    }   
}


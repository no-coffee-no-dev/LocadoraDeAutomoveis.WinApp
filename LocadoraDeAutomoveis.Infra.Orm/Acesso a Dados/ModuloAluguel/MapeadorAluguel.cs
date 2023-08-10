using LocadoraDeAutomoveis.Dominio.ModuloAutomovel;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocadoraDeAutomoveis.Dominio.ModuloAluguel;

namespace LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloAluguel
{
    public class MapeadorAluguel : IEntityTypeConfiguration<Aluguel>
    {
        public void Configure(EntityTypeBuilder<Aluguel> automovelBuilder)
        {

            automovelBuilder.ToTable("TBAluguel");

            automovelBuilder.Property(a => a.Id).IsRequired().ValueGeneratedNever();
            automovelBuilder.Property(a => a.ValorFinal).HasColumnType("decimal(9,2)").IsRequired();
            automovelBuilder.Property(a => a.DataDoAluguel).HasColumnType("datetime").IsRequired();
            automovelBuilder.Property(a => a.DataDaPrevistaDevolucao).HasColumnType("datetime").IsRequired();


            automovelBuilder.HasOne(a => a.Cupom).WithMany()
               .IsRequired()
               .HasConstraintName("FK_TBAluguel_TBCupom")
               .OnDelete(DeleteBehavior.NoAction);

            automovelBuilder.HasOne(a => a.Automovel).WithMany()
               .IsRequired()
               .HasConstraintName("FK_TBAluguel_TBAutomoveis")
               .OnDelete(DeleteBehavior.NoAction);


            automovelBuilder.HasOne(a => a.PlanoDeCobranca).WithMany()
            .IsRequired()
            .HasConstraintName("FK_TBAluguel_TBPlanoDeCobranca")
            .OnDelete(DeleteBehavior.NoAction);


            automovelBuilder.HasOne(a => a.Cliente).WithMany()
               .IsRequired()
               .HasConstraintName("FK_TBAluguel_TBCliente")
               .OnDelete(DeleteBehavior.NoAction);


            automovelBuilder.HasOne(a => a.GrupoDeAutomoveis)
               .WithMany()
               .IsRequired()
               .HasConstraintName("FK_TBAluguel_TBGrupoDeAutoveis")
               .OnDelete(DeleteBehavior.NoAction);

        }
        
    }
}

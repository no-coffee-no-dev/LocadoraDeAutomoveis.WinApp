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
        public void Configure(EntityTypeBuilder<Aluguel> aluguelBuilder)
        {

            aluguelBuilder.ToTable("TBAluguel");

            aluguelBuilder.Property(a => a.Id).IsRequired().ValueGeneratedNever();
            aluguelBuilder.Property(a => a.ValorFinal).HasColumnType("decimal(9,2)").IsRequired();
            aluguelBuilder.Property(a => a.DataDoAluguel).HasColumnType("datetime").IsRequired();
            aluguelBuilder.Property(a => a.DataDaPrevistaDevolucao).HasColumnType("datetime").IsRequired();
            aluguelBuilder.Property(a => a.Concluido).HasColumnType("bit").IsRequired();

            aluguelBuilder.HasMany(a => a.Multas)
                .WithMany()
                .UsingEntity(x => x.ToTable("TBAluguel_TBMultas"));

            aluguelBuilder.HasOne(a => a.Cupom)             
               .WithMany()
               .IsRequired(false)
               .HasConstraintName("FK_TBAluguel_TBCupom")
               .OnDelete(DeleteBehavior.NoAction);

            aluguelBuilder.HasOne(a => a.Automovel).WithMany()
               .IsRequired()
               .HasConstraintName("FK_TBAluguel_TBAutomoveis")
               .OnDelete(DeleteBehavior.NoAction);


            aluguelBuilder.HasOne(a => a.PlanoDeCobranca).WithMany()
            .IsRequired()
            .HasConstraintName("FK_TBAluguel_TBPlanoDeCobranca")
            .OnDelete(DeleteBehavior.NoAction);


            aluguelBuilder.HasOne(a => a.Cliente).WithMany()
               .IsRequired()
               .HasConstraintName("FK_TBAluguel_TBCliente")
               .OnDelete(DeleteBehavior.NoAction);


            aluguelBuilder.HasOne(a => a.GrupoDeAutomoveis)
               .WithMany()
               .IsRequired()
               .HasConstraintName("FK_TBAluguel_TBGrupoDeAutoveis")
               .OnDelete(DeleteBehavior.NoAction);

            aluguelBuilder.HasOne(a => a.Funcionario).WithMany()
              .IsRequired()
              .HasConstraintName("FK_TBAluguel_TBFuncionario")
              .OnDelete(DeleteBehavior.NoAction);

            aluguelBuilder.HasOne(a => a.Condutor).WithMany()
              .IsRequired()
              .HasConstraintName("FK_TBAluguel_TBCondutor")
              .OnDelete(DeleteBehavior.NoAction);

            aluguelBuilder.HasMany(a => a.TaxasEServicos)
                .WithMany()
                .UsingEntity(x => x.ToTable("TBAluguel_TBTaxaServico"));
        }
        
    }
}

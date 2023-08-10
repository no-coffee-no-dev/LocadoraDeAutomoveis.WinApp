using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocadoraDeAutomoveis.Dominio.ModuloAutomovel;

namespace LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloAutomovel
{
    public class MapeadorAutomovel : IEntityTypeConfiguration<Automovel>
    {
        public void Configure(EntityTypeBuilder<Automovel> cupomBuilder)
        {

            cupomBuilder.ToTable("TBAutomovel");

            cupomBuilder.Property(a => a.Id).IsRequired().ValueGeneratedNever();
            cupomBuilder.Property(a => a.Modelo).HasColumnType("varchar(100)").IsRequired();
            cupomBuilder.Property(a => a.Marca).HasColumnType("varchar(100)").IsRequired();
            cupomBuilder.Property(a => a.CapacidadeEmLitros).HasColumnType("integer").IsRequired();
            cupomBuilder.Property(a => a.Foto).HasColumnType("varbinary(MAX)").IsRequired();
            cupomBuilder.Property(a => a.TipoDeCombustivel).HasConversion<int>().IsRequired();
            cupomBuilder.Property(a => a.Cor).HasColumnType("varchar(100)").IsRequired();

            cupomBuilder.HasOne(a => a.GrupoDeAutomoveis)
               .WithMany()
               .IsRequired()
               .HasConstraintName("FK_TBAutomovel_TBGrupoDeAutoveis")
               .OnDelete(DeleteBehavior.NoAction);

        }
    }
}

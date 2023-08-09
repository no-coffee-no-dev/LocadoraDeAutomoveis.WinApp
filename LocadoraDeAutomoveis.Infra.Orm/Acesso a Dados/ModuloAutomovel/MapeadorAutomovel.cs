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
        public void Configure(EntityTypeBuilder<Automovel> automovelBuilder)
        {

            automovelBuilder.ToTable("TBAutomovel");

            automovelBuilder.Property(a => a.Id).IsRequired().ValueGeneratedNever();
            automovelBuilder.Property(a => a.Modelo).HasColumnType("varchar(100)").IsRequired();
            automovelBuilder.Property(a => a.Marca).HasColumnType("varchar(100)").IsRequired();
            automovelBuilder.Property(a => a.KmRodados).HasColumnType("integer").IsRequired();
            automovelBuilder.Property(a => a.Ano).HasColumnType("datetime").IsRequired();
            automovelBuilder.Property(a => a.Placa).HasColumnType("varchar(7)").IsRequired();
            automovelBuilder.Property(a => a.CapacidadeEmLitros).HasColumnType("integer").IsRequired();
            automovelBuilder.Property(a => a.Foto).HasColumnType("varbinary(MAX)").IsRequired();
            automovelBuilder.Property(a => a.TipoDeCombustivel).HasConversion<int>().IsRequired();
            automovelBuilder.Property(a => a.Cor).HasColumnType("varchar(100)").IsRequired();

            automovelBuilder.HasOne(a => a.GrupoDeAutomoveis)
               .WithMany()
               .IsRequired()
               .HasConstraintName("FK_TBAutomovel_TBGrupoDeAutoveis")
               .OnDelete(DeleteBehavior.NoAction);

        }
    }
}

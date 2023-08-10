using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloParceiro;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloCupom
{
    public class MapeadorCupom : IEntityTypeConfiguration<Cupom>
    {
        public void Configure(EntityTypeBuilder<Cupom> cupomBuilder)
        {

            cupomBuilder.ToTable("TBCupom");

            cupomBuilder.Property(p => p.Id).IsRequired().ValueGeneratedNever();
            cupomBuilder.Property(p => p.Nome).HasColumnType("varchar(100)").IsRequired();
            cupomBuilder.Property(p => p.DataDeValidade).HasColumnType("datetime").IsRequired();
            cupomBuilder.Property(p => p.Valor).HasColumnType("decimal(18,0)").IsRequired();
            cupomBuilder.Property(p => p.Expirado).HasColumnType("bit").IsRequired();

            cupomBuilder.HasOne(p => p.Parceiro)
               .WithMany()
               .IsRequired()
               .HasConstraintName("FK_TBCupom_TBParceiro")
               .OnDelete(DeleteBehavior.NoAction);

        }
    }
}

using LocadoraDeAutomoveis.Dominio.ModuloCupom;
using LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloGrupoDoAutomovel
{
    public class MapeadorGrupoDeAutomoveis : IEntityTypeConfiguration<GrupoDeAutomoveis>
    {
        public void Configure(EntityTypeBuilder<GrupoDeAutomoveis> cupomBuilder)
        {

            cupomBuilder.ToTable("TBGrupoDeAutomoveis");

            cupomBuilder.Property(g => g.Id).IsRequired().ValueGeneratedNever();
            cupomBuilder.Property(p => p.Nome).HasColumnType("varchar(100)").IsRequired();

        }
    }
}

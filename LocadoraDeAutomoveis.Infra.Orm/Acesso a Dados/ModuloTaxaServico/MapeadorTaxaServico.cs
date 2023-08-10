using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using LocadoraDeAutomoveis.Dominio.ModuloTaxaServico;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloTaxaServico
{
    public class MapeadorTaxaServico : IEntityTypeConfiguration<TaxaServico>
    {
        public void Configure(EntityTypeBuilder<TaxaServico> taxaServicoBuilder)
        {
            taxaServicoBuilder.ToTable("TBTaxaServico");

            taxaServicoBuilder.Property(p => p.Id).IsRequired().ValueGeneratedNever();
            taxaServicoBuilder.Property(p => p.Nome).HasColumnType("varchar(100)").IsRequired();
            taxaServicoBuilder.Property(p => p.Preco).HasColumnType("decimal").IsRequired();
            taxaServicoBuilder.Property(p => p.PlanoDeCalculo).HasColumnType("int").IsRequired();
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using LocadoraDeAutomoveis.Dominio.ModuloCliente;

namespace LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloCupom
{
    public class MapeadorCliente : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> clienteBuilder)
        {
            clienteBuilder.ToTable("TBCliente");

            clienteBuilder.Property(p => p.Id).IsRequired().ValueGeneratedNever();
            clienteBuilder.Property(p => p.Nome).HasColumnType("varchar(100)").IsRequired();
            clienteBuilder.Property(p => p.Email).HasColumnType("varchar(100)").IsRequired();
            clienteBuilder.Property(p => p.Telefone).HasColumnType("varchar(100)").IsRequired();
            clienteBuilder.Property(p => p.TipoCliente).HasColumnType("int").IsRequired();
            clienteBuilder.Property(p => p.Estado).HasColumnType("varchar(100)").IsRequired();
            clienteBuilder.Property(p => p.Cidade).HasColumnType("varchar(100)").IsRequired();
            clienteBuilder.Property(p => p.Bairro).HasColumnType("varchar(100)").IsRequired();
            clienteBuilder.Property(p => p.Rua).HasColumnType("varchar(100)").IsRequired();
            clienteBuilder.Property(p => p.Numero).HasColumnType("varchar(100)").IsRequired();
            clienteBuilder.Property(p => p.CNPJ).HasColumnType("varchar(100)").IsRequired();
            clienteBuilder.Property(p => p.CPF).HasColumnType("varchar(100)").IsRequired();
            clienteBuilder.Property(p => p.RG).HasColumnType("varchar(100)");
            clienteBuilder.Property(p => p.CNH).HasColumnType("varchar(100)");
        }
    }
}
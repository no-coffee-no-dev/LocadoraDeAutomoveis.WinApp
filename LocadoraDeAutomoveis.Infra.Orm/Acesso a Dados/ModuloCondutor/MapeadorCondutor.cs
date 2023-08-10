using LocadoraDeAutomoveis.Dominio.ModuloCondutor;
using LocadoraDeAutomoveis.Dominio.ModuloFuncionario;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloCondutor
{
    public class MapeadorCondutor : IEntityTypeConfiguration<Condutor>
    {
        public void Configure(EntityTypeBuilder<Condutor> condutorBuilder)
        {
            

            condutorBuilder.ToTable("TBCondutor");

            condutorBuilder.Property(p => p.Id).IsRequired().ValueGeneratedNever();
            condutorBuilder.Property(p => p.Nome).HasColumnType("varchar(100)").IsRequired();
            condutorBuilder.Property(p => p.Email).HasColumnType("varchar(100)").IsRequired();
            condutorBuilder.Property(p => p.Telefone).HasColumnType("varchar(100)").IsRequired();
            condutorBuilder.Property(p => p.CPF).HasColumnType("varchar(100)").IsRequired();
            condutorBuilder.Property(p => p.CNH).HasColumnType("varchar(100)").IsRequired();
            condutorBuilder.Property(p => p.ValidadeCNH).HasColumnType("varchar(100)").IsRequired();
            condutorBuilder.HasOne(p => p.Cliente)
               .WithMany()
               .IsRequired()
               .HasConstraintName("FK_TBCondutor_TBCliente")
               .OnDelete(DeleteBehavior.NoAction);
        }
    }
}

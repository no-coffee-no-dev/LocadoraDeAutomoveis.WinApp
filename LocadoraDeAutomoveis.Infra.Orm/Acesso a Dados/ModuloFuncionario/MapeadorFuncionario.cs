using LocadoraDeAutomoveis.Dominio.ModuloCliente;
using LocadoraDeAutomoveis.Dominio.ModuloFuncionario;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.ModuloFuncionario
{
    public class MapeadorFuncionario : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> funcionarioBuilder)
        {
            Funcionario F = new Funcionario();

            funcionarioBuilder.ToTable("TBFuncionario");

            funcionarioBuilder.Property(p => p.Id).IsRequired().ValueGeneratedNever();
            funcionarioBuilder.Property(p => p.nome).HasColumnType("varchar(100)").IsRequired();
            funcionarioBuilder.Property(p => p.admissao).HasColumnType("varchar(100)").IsRequired();
            funcionarioBuilder.Property(p => p.salario).HasColumnType("int").IsRequired();

        }
    }
}

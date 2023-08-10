﻿// <auto-generated />
using System;
using LocadoraDeAutomoveis.Infra.Orm.Acesso_a_Dados.Compartilhado;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LocadoraDeAutomoveis.Infra.Orm.Migrations
{
    [DbContext(typeof(LocadoraDeAutomoveisDbContext))]
    [Migration("20230809195311_TBAluguel")]
    partial class TBAluguel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LocadoraDeAutomoveis.Dominio.ModuloAluguel.Aluguel", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AutomovelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CupomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataDaPrevistaDevolucao")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("DataDoAluguel")
                        .HasColumnType("datetime");

                    b.Property<Guid>("GrupoDeAutomoveisId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlanoDeCobrancaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ValorFinal")
                        .HasColumnType("decimal(9,2)");

                    b.HasKey("Id");

                    b.HasIndex("AutomovelId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("CupomId");

                    b.HasIndex("GrupoDeAutomoveisId");

                    b.HasIndex("PlanoDeCobrancaId");

                    b.ToTable("TBAluguel", (string)null);
                });

            modelBuilder.Entity("LocadoraDeAutomoveis.Dominio.ModuloAutomovel.Automovel", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Ano")
                        .HasColumnType("datetime");

                    b.Property<int>("CapacidadeEmLitros")
                        .HasColumnType("integer");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<byte[]>("Foto")
                        .IsRequired()
                        .HasColumnType("varbinary(MAX)");

                    b.Property<Guid>("GrupoDeAutomoveisId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("KmRodados")
                        .HasColumnType("integer");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("varchar(7)");

                    b.Property<int>("TipoDeCombustivel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GrupoDeAutomoveisId");

                    b.ToTable("TBAutomovel", (string)null);
                });

            modelBuilder.Entity("LocadoraDeAutomoveis.Dominio.ModuloCliente.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CNH")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("TipoCliente")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TBCliente", (string)null);
                });

            modelBuilder.Entity("LocadoraDeAutomoveis.Dominio.ModuloCupom.Cupom", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataDeValidade")
                        .HasColumnType("datetime");

                    b.Property<bool>("Expirado")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("ParceiroId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,0)");

                    b.HasKey("Id");

                    b.HasIndex("ParceiroId");

                    b.ToTable("TBCupom", (string)null);
                });

            modelBuilder.Entity("LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel.GrupoDeAutomoveis", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("TBGrupoDeAutomoveis", (string)null);
                });

            modelBuilder.Entity("LocadoraDeAutomoveis.Dominio.ModuloParceiro.Parceiro", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("TBParceiro", (string)null);
                });

            modelBuilder.Entity("LocadoraDeAutomoveis.Dominio.ModuloPlanoDeCobranca.PlanoDeCobranca", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GrupoDeAutomoveisId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("KmDisponiveis")
                        .HasColumnType("decimal(18,0)");

                    b.Property<decimal>("PrecoDaDiaria")
                        .HasColumnType("decimal(18,0)");

                    b.Property<decimal?>("PrecoPorKM")
                        .HasColumnType("decimal(18,0)");

                    b.Property<int>("TipoDePlano")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GrupoDeAutomoveisId");

                    b.ToTable("TBPlanoDeCobranca", (string)null);
                });

            modelBuilder.Entity("LocadoraDeAutomoveis.Dominio.ModuloAluguel.Aluguel", b =>
                {
                    b.HasOne("LocadoraDeAutomoveis.Dominio.ModuloAutomovel.Automovel", "Automovel")
                        .WithMany()
                        .HasForeignKey("AutomovelId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBAluguel_TBAutomoveis");

                    b.HasOne("LocadoraDeAutomoveis.Dominio.ModuloCliente.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBAluguel_TBCliente");

                    b.HasOne("LocadoraDeAutomoveis.Dominio.ModuloCupom.Cupom", "Cupom")
                        .WithMany()
                        .HasForeignKey("CupomId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBAluguel_TBCupom");

                    b.HasOne("LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel.GrupoDeAutomoveis", "GrupoDeAutomoveis")
                        .WithMany()
                        .HasForeignKey("GrupoDeAutomoveisId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBAluguel_TBGrupoDeAutoveis");

                    b.HasOne("LocadoraDeAutomoveis.Dominio.ModuloPlanoDeCobranca.PlanoDeCobranca", "PlanoDeCobranca")
                        .WithMany()
                        .HasForeignKey("PlanoDeCobrancaId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBAluguel_TBPlanoDeCobranca");

                    b.Navigation("Automovel");

                    b.Navigation("Cliente");

                    b.Navigation("Cupom");

                    b.Navigation("GrupoDeAutomoveis");

                    b.Navigation("PlanoDeCobranca");
                });

            modelBuilder.Entity("LocadoraDeAutomoveis.Dominio.ModuloAutomovel.Automovel", b =>
                {
                    b.HasOne("LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel.GrupoDeAutomoveis", "GrupoDeAutomoveis")
                        .WithMany()
                        .HasForeignKey("GrupoDeAutomoveisId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBAutomovel_TBGrupoDeAutoveis");

                    b.Navigation("GrupoDeAutomoveis");
                });

            modelBuilder.Entity("LocadoraDeAutomoveis.Dominio.ModuloCupom.Cupom", b =>
                {
                    b.HasOne("LocadoraDeAutomoveis.Dominio.ModuloParceiro.Parceiro", "Parceiro")
                        .WithMany()
                        .HasForeignKey("ParceiroId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBCupom_TBParceiro");

                    b.Navigation("Parceiro");
                });

            modelBuilder.Entity("LocadoraDeAutomoveis.Dominio.ModuloPlanoDeCobranca.PlanoDeCobranca", b =>
                {
                    b.HasOne("LocadoraDeAutomoveis.Dominio.ModuloGrupoDoAutomovel.GrupoDeAutomoveis", "GrupoDeAutomoveis")
                        .WithMany()
                        .HasForeignKey("GrupoDeAutomoveisId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBPlanoDeCobranca_TBGrupoDeAutomoveis");

                    b.Navigation("GrupoDeAutomoveis");
                });
#pragma warning restore 612, 618
        }
    }
}

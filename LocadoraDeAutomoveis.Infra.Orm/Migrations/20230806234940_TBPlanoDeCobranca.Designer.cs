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
    [Migration("20230806234940_TBPlanoDeCobranca")]
    partial class TBPlanoDeCobranca
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

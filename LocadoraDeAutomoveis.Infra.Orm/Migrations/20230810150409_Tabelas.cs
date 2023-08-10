using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocadoraDeAutomoveis.Infra.Orm.Migrations
{
    /// <inheritdoc />
    public partial class Tabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Multa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBCliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(100)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(100)", nullable: false),
                    CNPJ = table.Column<string>(type: "varchar(100)", nullable: false),
                    CNH = table.Column<string>(type: "varchar(100)", nullable: false),
                    RG = table.Column<string>(type: "varchar(100)", nullable: false),
                    Estado = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(100)", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(100)", nullable: false),
                    Rua = table.Column<string>(type: "varchar(100)", nullable: false),
                    Numero = table.Column<string>(type: "varchar(100)", nullable: false),
                    TipoCliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBFuncionario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    admissao = table.Column<string>(type: "varchar(100)", nullable: false),
                    salario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBFuncionario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBGrupoDeAutomoveis",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBGrupoDeAutomoveis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBParceiro",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBParceiro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBTaxaServico",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(38,17)", nullable: false),
                    PlanoDeCalculo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBTaxaServico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBCondutor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    clienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    email = table.Column<string>(type: "varchar(100)", nullable: false),
                    telefone = table.Column<string>(type: "varchar(100)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(100)", nullable: false),
                    CNH = table.Column<string>(type: "varchar(100)", nullable: false),
                    validadeCNH = table.Column<string>(type: "varchar(100)", nullable: false),
                    tipoCondutor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCondutor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBCondutor_TBCliente",
                        column: x => x.clienteId,
                        principalTable: "TBCliente",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TBAutomovel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Modelo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Marca = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cor = table.Column<string>(type: "varchar(100)", nullable: false),
                    Placa = table.Column<string>(type: "varchar(7)", nullable: false),
                    Ano = table.Column<DateTime>(type: "datetime", nullable: false),
                    KmRodados = table.Column<int>(type: "integer", nullable: false),
                    GrupoDeAutomoveisId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CapacidadeEmLitros = table.Column<int>(type: "integer", nullable: false),
                    Foto = table.Column<byte[]>(type: "varbinary(MAX)", nullable: false),
                    TipoDeCombustivel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBAutomovel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBAutomovel_TBGrupoDeAutoveis",
                        column: x => x.GrupoDeAutomoveisId,
                        principalTable: "TBGrupoDeAutomoveis",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TBPlanoDeCobranca",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GrupoDeAutomoveisId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrecoDaDiaria = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    PrecoPorKM = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    KmDisponiveis = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    TipoDePlano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBPlanoDeCobranca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBPlanoDeCobranca_TBGrupoDeAutomoveis",
                        column: x => x.GrupoDeAutomoveisId,
                        principalTable: "TBGrupoDeAutomoveis",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TBCupom",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    ParceiroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    DataDeValidade = table.Column<DateTime>(type: "datetime", nullable: false),
                    Expirado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBCupom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBCupom_TBParceiro",
                        column: x => x.ParceiroId,
                        principalTable: "TBParceiro",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TBAluguel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ValorFinal = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    FuncionarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GrupoDeAutomoveisId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataDoAluguel = table.Column<DateTime>(type: "datetime", nullable: false),
                    CondutorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AutomovelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataDaPrevistaDevolucao = table.Column<DateTime>(type: "datetime", nullable: false),
                    PlanoDeCobrancaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CupomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    KmsPercoridos = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Concluido = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBAluguel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBAluguel_TBAutomoveis",
                        column: x => x.AutomovelId,
                        principalTable: "TBAutomovel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TBAluguel_TBCliente",
                        column: x => x.ClienteId,
                        principalTable: "TBCliente",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TBAluguel_TBCondutor",
                        column: x => x.CondutorId,
                        principalTable: "TBCondutor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TBAluguel_TBCupom",
                        column: x => x.CupomId,
                        principalTable: "TBCupom",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TBAluguel_TBFuncionario",
                        column: x => x.FuncionarioId,
                        principalTable: "TBFuncionario",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TBAluguel_TBGrupoDeAutoveis",
                        column: x => x.GrupoDeAutomoveisId,
                        principalTable: "TBGrupoDeAutomoveis",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TBAluguel_TBPlanoDeCobranca",
                        column: x => x.PlanoDeCobrancaId,
                        principalTable: "TBPlanoDeCobranca",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TBAluguel_TBMultas",
                columns: table => new
                {
                    AluguelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MultasId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBAluguel_TBMultas", x => new { x.AluguelId, x.MultasId });
                    table.ForeignKey(
                        name: "FK_TBAluguel_TBMultas_Multa_MultasId",
                        column: x => x.MultasId,
                        principalTable: "Multa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBAluguel_TBMultas_TBAluguel_AluguelId",
                        column: x => x.AluguelId,
                        principalTable: "TBAluguel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBAluguel_TBTaxaServico",
                columns: table => new
                {
                    AluguelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaxasEServicosId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBAluguel_TBTaxaServico", x => new { x.AluguelId, x.TaxasEServicosId });
                    table.ForeignKey(
                        name: "FK_TBAluguel_TBTaxaServico_TBAluguel_AluguelId",
                        column: x => x.AluguelId,
                        principalTable: "TBAluguel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBAluguel_TBTaxaServico_TBTaxaServico_TaxasEServicosId",
                        column: x => x.TaxasEServicosId,
                        principalTable: "TBTaxaServico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBAluguel_AutomovelId",
                table: "TBAluguel",
                column: "AutomovelId");

            migrationBuilder.CreateIndex(
                name: "IX_TBAluguel_ClienteId",
                table: "TBAluguel",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_TBAluguel_CondutorId",
                table: "TBAluguel",
                column: "CondutorId");

            migrationBuilder.CreateIndex(
                name: "IX_TBAluguel_CupomId",
                table: "TBAluguel",
                column: "CupomId");

            migrationBuilder.CreateIndex(
                name: "IX_TBAluguel_FuncionarioId",
                table: "TBAluguel",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TBAluguel_GrupoDeAutomoveisId",
                table: "TBAluguel",
                column: "GrupoDeAutomoveisId");

            migrationBuilder.CreateIndex(
                name: "IX_TBAluguel_PlanoDeCobrancaId",
                table: "TBAluguel",
                column: "PlanoDeCobrancaId");

            migrationBuilder.CreateIndex(
                name: "IX_TBAluguel_TBMultas_MultasId",
                table: "TBAluguel_TBMultas",
                column: "MultasId");

            migrationBuilder.CreateIndex(
                name: "IX_TBAluguel_TBTaxaServico_TaxasEServicosId",
                table: "TBAluguel_TBTaxaServico",
                column: "TaxasEServicosId");

            migrationBuilder.CreateIndex(
                name: "IX_TBAutomovel_GrupoDeAutomoveisId",
                table: "TBAutomovel",
                column: "GrupoDeAutomoveisId");

            migrationBuilder.CreateIndex(
                name: "IX_TBCondutor_clienteId",
                table: "TBCondutor",
                column: "clienteId");

            migrationBuilder.CreateIndex(
                name: "IX_TBCupom_ParceiroId",
                table: "TBCupom",
                column: "ParceiroId");

            migrationBuilder.CreateIndex(
                name: "IX_TBPlanoDeCobranca_GrupoDeAutomoveisId",
                table: "TBPlanoDeCobranca",
                column: "GrupoDeAutomoveisId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBAluguel_TBMultas");

            migrationBuilder.DropTable(
                name: "TBAluguel_TBTaxaServico");

            migrationBuilder.DropTable(
                name: "Multa");

            migrationBuilder.DropTable(
                name: "TBAluguel");

            migrationBuilder.DropTable(
                name: "TBTaxaServico");

            migrationBuilder.DropTable(
                name: "TBAutomovel");

            migrationBuilder.DropTable(
                name: "TBCondutor");

            migrationBuilder.DropTable(
                name: "TBCupom");

            migrationBuilder.DropTable(
                name: "TBFuncionario");

            migrationBuilder.DropTable(
                name: "TBPlanoDeCobranca");

            migrationBuilder.DropTable(
                name: "TBCliente");

            migrationBuilder.DropTable(
                name: "TBParceiro");

            migrationBuilder.DropTable(
                name: "TBGrupoDeAutomoveis");
        }
    }
}

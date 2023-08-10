using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocadoraDeAutomoveis.Infra.Orm.Migrations
{
    /// <inheritdoc />
    public partial class TBSAluguelEtaxaAtualizadas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBAluguel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ValorFinal = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GrupoDeAutomoveisId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataDoAluguel = table.Column<DateTime>(type: "datetime", nullable: false),
                    AutomovelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataDaPrevistaDevolucao = table.Column<DateTime>(type: "datetime", nullable: false),
                    PlanoDeCobrancaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CupomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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
                        name: "FK_TBAluguel_TBCupom",
                        column: x => x.CupomId,
                        principalTable: "TBCupom",
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
                name: "IX_TBAluguel_CupomId",
                table: "TBAluguel",
                column: "CupomId");

            migrationBuilder.CreateIndex(
                name: "IX_TBAluguel_GrupoDeAutomoveisId",
                table: "TBAluguel",
                column: "GrupoDeAutomoveisId");

            migrationBuilder.CreateIndex(
                name: "IX_TBAluguel_PlanoDeCobrancaId",
                table: "TBAluguel",
                column: "PlanoDeCobrancaId");

            migrationBuilder.CreateIndex(
                name: "IX_TBAluguel_TBTaxaServico_TaxasEServicosId",
                table: "TBAluguel_TBTaxaServico",
                column: "TaxasEServicosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBAluguel_TBTaxaServico");

            migrationBuilder.DropTable(
                name: "TBAluguel");

            migrationBuilder.DropTable(
                name: "TBTaxaServico");
        }
    }
}

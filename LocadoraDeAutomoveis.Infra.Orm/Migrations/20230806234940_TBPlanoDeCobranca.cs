using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocadoraDeAutomoveis.Infra.Orm.Migrations
{
    /// <inheritdoc />
    public partial class TBPlanoDeCobranca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_TBPlanoDeCobranca_GrupoDeAutomoveisId",
                table: "TBPlanoDeCobranca",
                column: "GrupoDeAutomoveisId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBPlanoDeCobranca");
        }
    }
}

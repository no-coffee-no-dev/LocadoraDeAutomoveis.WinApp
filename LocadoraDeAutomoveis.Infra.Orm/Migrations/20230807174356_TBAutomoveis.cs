using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocadoraDeAutomoveis.Infra.Orm.Migrations
{
    /// <inheritdoc />
    public partial class TBAutomoveis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBAutomovel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Modelo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Marca = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cor = table.Column<string>(type: "varchar(100)", nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_TBAutomovel_GrupoDeAutomoveisId",
                table: "TBAutomovel",
                column: "GrupoDeAutomoveisId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBAutomovel");
        }
    }
}

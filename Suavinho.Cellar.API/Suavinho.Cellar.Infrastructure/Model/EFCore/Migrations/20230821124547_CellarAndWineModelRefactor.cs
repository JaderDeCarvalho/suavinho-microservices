using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Suavinho.Cellar.Infrastructure.Model.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class CellarAndWineModelRefactor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CellarWines");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Wines",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CellarWine",
                columns: table => new
                {
                    CellarsId = table.Column<int>(type: "integer", nullable: false),
                    WinesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellarWine", x => new { x.CellarsId, x.WinesId });
                    table.ForeignKey(
                        name: "FK_CellarWine_Cellars_CellarsId",
                        column: x => x.CellarsId,
                        principalTable: "Cellars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CellarWine_Wines_WinesId",
                        column: x => x.WinesId,
                        principalTable: "Wines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CellarWine_WinesId",
                table: "CellarWine",
                column: "WinesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CellarWine");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Wines");

            migrationBuilder.CreateTable(
                name: "CellarWines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CellarId = table.Column<int>(type: "integer", nullable: false),
                    WineId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellarWines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CellarWines_Cellars_CellarId",
                        column: x => x.CellarId,
                        principalTable: "Cellars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CellarWines_Wines_WineId",
                        column: x => x.WineId,
                        principalTable: "Wines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CellarWines_CellarId",
                table: "CellarWines",
                column: "CellarId");

            migrationBuilder.CreateIndex(
                name: "IX_CellarWines_WineId",
                table: "CellarWines",
                column: "WineId");
        }
    }
}

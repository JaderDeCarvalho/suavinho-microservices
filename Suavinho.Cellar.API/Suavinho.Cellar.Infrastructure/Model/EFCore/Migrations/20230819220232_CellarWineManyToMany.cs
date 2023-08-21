using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Suavinho.Cellar.Infrastructure.Model.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class CellarWineManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CellarWines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WineId = table.Column<int>(type: "integer", nullable: false),
                    CellarId = table.Column<int>(type: "integer", nullable: false),
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CellarWines");
        }
    }
}

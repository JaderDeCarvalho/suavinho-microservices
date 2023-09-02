using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Suavinho.Cellar.Infrastructure.Model.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class SQLServerMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cellars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cellars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    AlcoholContent = table.Column<int>(type: "int", nullable: false),
                    Vintage = table.Column<int>(type: "int", nullable: false),
                    Grapes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsBarrelAged = table.Column<bool>(type: "bit", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CellarWines",
                columns: table => new
                {
                    CellarId = table.Column<int>(type: "int", nullable: false),
                    WineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellarWines", x => new { x.CellarId, x.WineId });
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
                name: "IX_CellarWines_WineId",
                table: "CellarWines",
                column: "WineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CellarWines");

            migrationBuilder.DropTable(
                name: "Cellars");

            migrationBuilder.DropTable(
                name: "Wines");
        }
    }
}

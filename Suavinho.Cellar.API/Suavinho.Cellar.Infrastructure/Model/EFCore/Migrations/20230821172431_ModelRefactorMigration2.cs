using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Suavinho.Cellar.Infrastructure.Model.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class ModelRefactorMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CellarWine_Cellars_CellarId",
                table: "CellarWine");

            migrationBuilder.DropForeignKey(
                name: "FK_CellarWine_Wines_WineId",
                table: "CellarWine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CellarWine",
                table: "CellarWine");

            migrationBuilder.RenameTable(
                name: "CellarWine",
                newName: "CellarWines");

            migrationBuilder.RenameIndex(
                name: "IX_CellarWine_WineId",
                table: "CellarWines",
                newName: "IX_CellarWines_WineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CellarWines",
                table: "CellarWines",
                columns: new[] { "CellarId", "WineId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CellarWines_Cellars_CellarId",
                table: "CellarWines",
                column: "CellarId",
                principalTable: "Cellars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CellarWines_Wines_WineId",
                table: "CellarWines",
                column: "WineId",
                principalTable: "Wines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CellarWines_Cellars_CellarId",
                table: "CellarWines");

            migrationBuilder.DropForeignKey(
                name: "FK_CellarWines_Wines_WineId",
                table: "CellarWines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CellarWines",
                table: "CellarWines");

            migrationBuilder.RenameTable(
                name: "CellarWines",
                newName: "CellarWine");

            migrationBuilder.RenameIndex(
                name: "IX_CellarWines_WineId",
                table: "CellarWine",
                newName: "IX_CellarWine_WineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CellarWine",
                table: "CellarWine",
                columns: new[] { "CellarId", "WineId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CellarWine_Cellars_CellarId",
                table: "CellarWine",
                column: "CellarId",
                principalTable: "Cellars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CellarWine_Wines_WineId",
                table: "CellarWine",
                column: "WineId",
                principalTable: "Wines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

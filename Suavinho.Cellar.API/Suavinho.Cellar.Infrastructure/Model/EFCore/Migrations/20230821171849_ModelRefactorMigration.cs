using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Suavinho.Cellar.Infrastructure.Model.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class ModelRefactorMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CellarWine_Cellars_CellarsId",
                table: "CellarWine");

            migrationBuilder.DropForeignKey(
                name: "FK_CellarWine_Wines_WinesId",
                table: "CellarWine");

            migrationBuilder.RenameColumn(
                name: "WinesId",
                table: "CellarWine",
                newName: "WineId");

            migrationBuilder.RenameColumn(
                name: "CellarsId",
                table: "CellarWine",
                newName: "CellarId");

            migrationBuilder.RenameIndex(
                name: "IX_CellarWine_WinesId",
                table: "CellarWine",
                newName: "IX_CellarWine_WineId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CellarWine_Cellars_CellarId",
                table: "CellarWine");

            migrationBuilder.DropForeignKey(
                name: "FK_CellarWine_Wines_WineId",
                table: "CellarWine");

            migrationBuilder.RenameColumn(
                name: "WineId",
                table: "CellarWine",
                newName: "WinesId");

            migrationBuilder.RenameColumn(
                name: "CellarId",
                table: "CellarWine",
                newName: "CellarsId");

            migrationBuilder.RenameIndex(
                name: "IX_CellarWine_WineId",
                table: "CellarWine",
                newName: "IX_CellarWine_WinesId");

            migrationBuilder.AddForeignKey(
                name: "FK_CellarWine_Cellars_CellarsId",
                table: "CellarWine",
                column: "CellarsId",
                principalTable: "Cellars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CellarWine_Wines_WinesId",
                table: "CellarWine",
                column: "WinesId",
                principalTable: "Wines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

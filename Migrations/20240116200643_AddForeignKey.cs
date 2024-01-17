using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetSeries.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Animes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Animes_CategoryId",
                table: "Animes",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animes_Categories_CategoryId",
                table: "Animes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animes_Categories_CategoryId",
                table: "Animes");

            migrationBuilder.DropIndex(
                name: "IX_Animes_CategoryId",
                table: "Animes");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Animes");
        }
    }
}

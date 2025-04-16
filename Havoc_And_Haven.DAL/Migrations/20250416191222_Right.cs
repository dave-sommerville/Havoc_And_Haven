using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havoc_And_Haven.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Right : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Lairs_LairId1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_LairId1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LairId1",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LairId1",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_LairId1",
                table: "Users",
                column: "LairId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Lairs_LairId1",
                table: "Users",
                column: "LairId1",
                principalTable: "Lairs",
                principalColumn: "LairId");
        }
    }
}

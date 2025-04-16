using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havoc_And_Haven.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Addherosdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HeroId",
                table: "Battles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VillainId",
                table: "Battles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Battles_HeroId",
                table: "Battles",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_Battles_VillainId",
                table: "Battles",
                column: "VillainId");

            migrationBuilder.AddForeignKey(
                name: "FK_Battles_Users_HeroId",
                table: "Battles",
                column: "HeroId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Battles_Users_VillainId",
                table: "Battles",
                column: "VillainId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Battles_Users_HeroId",
                table: "Battles");

            migrationBuilder.DropForeignKey(
                name: "FK_Battles_Users_VillainId",
                table: "Battles");

            migrationBuilder.DropIndex(
                name: "IX_Battles_HeroId",
                table: "Battles");

            migrationBuilder.DropIndex(
                name: "IX_Battles_VillainId",
                table: "Battles");

            migrationBuilder.DropColumn(
                name: "HeroId",
                table: "Battles");

            migrationBuilder.DropColumn(
                name: "VillainId",
                table: "Battles");
        }
    }
}

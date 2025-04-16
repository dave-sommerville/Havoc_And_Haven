using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havoc_And_Haven.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddBattleId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BattleId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_BattleId",
                table: "Users",
                column: "BattleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Battles_BattleId",
                table: "Users",
                column: "BattleId",
                principalTable: "Battles",
                principalColumn: "BattleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Battles_BattleId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_BattleId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BattleId",
                table: "Users");
        }
    }
}

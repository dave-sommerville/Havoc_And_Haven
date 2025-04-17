using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havoc_And_Haven.DAL.Migrations
{
    /// <inheritdoc />
    public partial class fixingdeletebehaviour : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Headquarters_HeadquartersId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Lairs_LairId",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Headquarters_HeadquartersId",
                table: "Users",
                column: "HeadquartersId",
                principalTable: "Headquarters",
                principalColumn: "HeadquartersId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Lairs_LairId",
                table: "Users",
                column: "LairId",
                principalTable: "Lairs",
                principalColumn: "LairId",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Headquarters_HeadquartersId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Lairs_LairId",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Headquarters_HeadquartersId",
                table: "Users",
                column: "HeadquartersId",
                principalTable: "Headquarters",
                principalColumn: "HeadquartersId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Lairs_LairId",
                table: "Users",
                column: "LairId",
                principalTable: "Lairs",
                principalColumn: "LairId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

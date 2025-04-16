using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havoc_And_Haven.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CrisisEventUser_User_HeroesUserId",
                table: "CrisisEventUser");

            migrationBuilder.DropForeignKey(
                name: "FK_CrisisEventUser1_User_VillainsUserId",
                table: "CrisisEventUser1");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Headquarters_HeadquartersId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Lairs_LairId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Lairs_LairId1",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_User_LairId1",
                table: "Users",
                newName: "IX_Users_LairId1");

            migrationBuilder.RenameIndex(
                name: "IX_User_LairId",
                table: "Users",
                newName: "IX_Users_LairId");

            migrationBuilder.RenameIndex(
                name: "IX_User_HeadquartersId",
                table: "Users",
                newName: "IX_Users_HeadquartersId");

            migrationBuilder.AlterColumn<string>(
                name: "Winner",
                table: "Battles",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CrisisEventUser_Users_HeroesUserId",
                table: "CrisisEventUser",
                column: "HeroesUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CrisisEventUser1_Users_VillainsUserId",
                table: "CrisisEventUser1",
                column: "VillainsUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Headquarters_HeadquartersId",
                table: "Users",
                column: "HeadquartersId",
                principalTable: "Headquarters",
                principalColumn: "HeadquartersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Lairs_LairId",
                table: "Users",
                column: "LairId",
                principalTable: "Lairs",
                principalColumn: "LairId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Lairs_LairId1",
                table: "Users",
                column: "LairId1",
                principalTable: "Lairs",
                principalColumn: "LairId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CrisisEventUser_Users_HeroesUserId",
                table: "CrisisEventUser");

            migrationBuilder.DropForeignKey(
                name: "FK_CrisisEventUser1_Users_VillainsUserId",
                table: "CrisisEventUser1");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Headquarters_HeadquartersId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Lairs_LairId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Lairs_LairId1",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameIndex(
                name: "IX_Users_LairId1",
                table: "User",
                newName: "IX_User_LairId1");

            migrationBuilder.RenameIndex(
                name: "IX_Users_LairId",
                table: "User",
                newName: "IX_User_LairId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_HeadquartersId",
                table: "User",
                newName: "IX_User_HeadquartersId");

            migrationBuilder.AlterColumn<string>(
                name: "Winner",
                table: "Battles",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CrisisEventUser_User_HeroesUserId",
                table: "CrisisEventUser",
                column: "HeroesUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CrisisEventUser1_User_VillainsUserId",
                table: "CrisisEventUser1",
                column: "VillainsUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Headquarters_HeadquartersId",
                table: "User",
                column: "HeadquartersId",
                principalTable: "Headquarters",
                principalColumn: "HeadquartersId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Lairs_LairId",
                table: "User",
                column: "LairId",
                principalTable: "Lairs",
                principalColumn: "LairId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Lairs_LairId1",
                table: "User",
                column: "LairId1",
                principalTable: "Lairs",
                principalColumn: "LairId");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havoc_And_Haven.DAL.Migrations
{
    /// <inheritdoc />
    public partial class userupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrisisEventUser");

            migrationBuilder.DropTable(
                name: "CrisisEventUser1");

            migrationBuilder.CreateTable(
                name: "CrisisEventUsers",
                columns: table => new
                {
                    CrisisEventCrisisId = table.Column<int>(type: "int", nullable: false),
                    HeroesUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrisisEventUsers", x => new { x.CrisisEventCrisisId, x.HeroesUserId });
                    table.ForeignKey(
                        name: "FK_CrisisEventUsers_CrisisEvents_CrisisEventCrisisId",
                        column: x => x.CrisisEventCrisisId,
                        principalTable: "CrisisEvents",
                        principalColumn: "CrisisId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CrisisEventUsers_Users_HeroesUserId",
                        column: x => x.HeroesUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrisisEventUsers1",
                columns: table => new
                {
                    CrisisEvent1CrisisId = table.Column<int>(type: "int", nullable: false),
                    VillainsUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrisisEventUsers1", x => new { x.CrisisEvent1CrisisId, x.VillainsUserId });
                    table.ForeignKey(
                        name: "FK_CrisisEventUsers1_CrisisEvents_CrisisEvent1CrisisId",
                        column: x => x.CrisisEvent1CrisisId,
                        principalTable: "CrisisEvents",
                        principalColumn: "CrisisId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CrisisEventUsers1_Users_VillainsUserId",
                        column: x => x.VillainsUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CrisisEventUsers_HeroesUserId",
                table: "CrisisEventUsers",
                column: "HeroesUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CrisisEventUsers1_VillainsUserId",
                table: "CrisisEventUsers1",
                column: "VillainsUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CrisisEventUsers");

            migrationBuilder.DropTable(
                name: "CrisisEventUsers1");

            migrationBuilder.CreateTable(
                name: "CrisisEventUser",
                columns: table => new
                {
                    CrisisEventCrisisId = table.Column<int>(type: "int", nullable: false),
                    HeroesUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrisisEventUser", x => new { x.CrisisEventCrisisId, x.HeroesUserId });
                    table.ForeignKey(
                        name: "FK_CrisisEventUser_CrisisEvents_CrisisEventCrisisId",
                        column: x => x.CrisisEventCrisisId,
                        principalTable: "CrisisEvents",
                        principalColumn: "CrisisId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CrisisEventUser_Users_HeroesUserId",
                        column: x => x.HeroesUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrisisEventUser1",
                columns: table => new
                {
                    CrisisEvent1CrisisId = table.Column<int>(type: "int", nullable: false),
                    VillainsUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrisisEventUser1", x => new { x.CrisisEvent1CrisisId, x.VillainsUserId });
                    table.ForeignKey(
                        name: "FK_CrisisEventUser1_CrisisEvents_CrisisEvent1CrisisId",
                        column: x => x.CrisisEvent1CrisisId,
                        principalTable: "CrisisEvents",
                        principalColumn: "CrisisId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CrisisEventUser1_Users_VillainsUserId",
                        column: x => x.VillainsUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CrisisEventUser_HeroesUserId",
                table: "CrisisEventUser",
                column: "HeroesUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CrisisEventUser1_VillainsUserId",
                table: "CrisisEventUser1",
                column: "VillainsUserId");
        }
    }
}

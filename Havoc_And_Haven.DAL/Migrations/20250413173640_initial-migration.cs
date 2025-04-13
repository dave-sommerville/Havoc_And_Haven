using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havoc_And_Haven.DAL.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Neighborhood = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "CrisisEvents",
                columns: table => new
                {
                    CrisisId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsResolved = table.Column<bool>(type: "bit", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrisisEvents", x => x.CrisisId);
                    table.ForeignKey(
                        name: "FK_CrisisEvents_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Headquarters",
                columns: table => new
                {
                    HeadquartersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headquarters", x => x.HeadquartersId);
                    table.ForeignKey(
                        name: "FK_Headquarters_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lairs",
                columns: table => new
                {
                    LairId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lairs", x => x.LairId);
                    table.ForeignKey(
                        name: "FK_Lairs_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Battles",
                columns: table => new
                {
                    BattleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncidentBegan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Winner = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CrisisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Battles", x => x.BattleId);
                    table.ForeignKey(
                        name: "FK_Battles_CrisisEvents_CrisisId",
                        column: x => x.CrisisId,
                        principalTable: "CrisisEvents",
                        principalColumn: "CrisisId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OriginStory = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PowerLevel = table.Column<int>(type: "int", nullable: false),
                    HeadquartersId = table.Column<int>(type: "int", nullable: true),
                    LairId = table.Column<int>(type: "int", nullable: true),
                    LairId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_Headquarters_HeadquartersId",
                        column: x => x.HeadquartersId,
                        principalTable: "Headquarters",
                        principalColumn: "HeadquartersId");
                    table.ForeignKey(
                        name: "FK_User_Lairs_LairId",
                        column: x => x.LairId,
                        principalTable: "Lairs",
                        principalColumn: "LairId");
                    table.ForeignKey(
                        name: "FK_User_Lairs_LairId1",
                        column: x => x.LairId1,
                        principalTable: "Lairs",
                        principalColumn: "LairId");
                });

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
                        name: "FK_CrisisEventUser_User_HeroesUserId",
                        column: x => x.HeroesUserId,
                        principalTable: "User",
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
                        name: "FK_CrisisEventUser1_User_VillainsUserId",
                        column: x => x.VillainsUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Battles_CrisisId",
                table: "Battles",
                column: "CrisisId");

            migrationBuilder.CreateIndex(
                name: "IX_CrisisEvents_LocationId",
                table: "CrisisEvents",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_CrisisEventUser_HeroesUserId",
                table: "CrisisEventUser",
                column: "HeroesUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CrisisEventUser1_VillainsUserId",
                table: "CrisisEventUser1",
                column: "VillainsUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Headquarters_LocationId",
                table: "Headquarters",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Lairs_LocationId",
                table: "Lairs",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_User_HeadquartersId",
                table: "User",
                column: "HeadquartersId");

            migrationBuilder.CreateIndex(
                name: "IX_User_LairId",
                table: "User",
                column: "LairId");

            migrationBuilder.CreateIndex(
                name: "IX_User_LairId1",
                table: "User",
                column: "LairId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Battles");

            migrationBuilder.DropTable(
                name: "CrisisEventUser");

            migrationBuilder.DropTable(
                name: "CrisisEventUser1");

            migrationBuilder.DropTable(
                name: "CrisisEvents");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Headquarters");

            migrationBuilder.DropTable(
                name: "Lairs");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havoc_And_Haven.DAL.Migrations
{
    /// <inheritdoc />
    public partial class kk : Migration
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
                name: "Users",
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
                    LairId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Headquarters_HeadquartersId",
                        column: x => x.HeadquartersId,
                        principalTable: "Headquarters",
                        principalColumn: "HeadquartersId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Users_Lairs_LairId",
                        column: x => x.LairId,
                        principalTable: "Lairs",
                        principalColumn: "LairId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Battles",
                columns: table => new
                {
                    BattleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncidentBegan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Winner = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CrisisId = table.Column<int>(type: "int", nullable: false),
                    HeroId = table.Column<int>(type: "int", nullable: true),
                    VillainId = table.Column<int>(type: "int", nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Battles_Users_HeroId",
                        column: x => x.HeroId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Battles_Users_VillainId",
                        column: x => x.VillainId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CrisisEventHeroes",
                columns: table => new
                {
                    CrisisEventId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrisisEventHeroes", x => new { x.CrisisEventId, x.UserId });
                    table.ForeignKey(
                        name: "FK_CrisisEventHeroes_CrisisEvents_CrisisEventId",
                        column: x => x.CrisisEventId,
                        principalTable: "CrisisEvents",
                        principalColumn: "CrisisId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CrisisEventHeroes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CrisisEventVillains",
                columns: table => new
                {
                    CrisisEventId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrisisEventVillains", x => new { x.CrisisEventId, x.UserId });
                    table.ForeignKey(
                        name: "FK_CrisisEventVillains_CrisisEvents_CrisisEventId",
                        column: x => x.CrisisEventId,
                        principalTable: "CrisisEvents",
                        principalColumn: "CrisisId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CrisisEventVillains_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Battles_CrisisId",
                table: "Battles",
                column: "CrisisId");

            migrationBuilder.CreateIndex(
                name: "IX_Battles_HeroId",
                table: "Battles",
                column: "HeroId");

            migrationBuilder.CreateIndex(
                name: "IX_Battles_VillainId",
                table: "Battles",
                column: "VillainId");

            migrationBuilder.CreateIndex(
                name: "IX_CrisisEventHeroes_UserId",
                table: "CrisisEventHeroes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CrisisEvents_LocationId",
                table: "CrisisEvents",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_CrisisEventVillains_UserId",
                table: "CrisisEventVillains",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Headquarters_LocationId",
                table: "Headquarters",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Lairs_LocationId",
                table: "Lairs",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_HeadquartersId",
                table: "Users",
                column: "HeadquartersId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_LairId",
                table: "Users",
                column: "LairId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Battles");

            migrationBuilder.DropTable(
                name: "CrisisEventHeroes");

            migrationBuilder.DropTable(
                name: "CrisisEventVillains");

            migrationBuilder.DropTable(
                name: "CrisisEvents");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Headquarters");

            migrationBuilder.DropTable(
                name: "Lairs");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LCFinalProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Directory = table.Column<string>(nullable: true),
                    GameDate = table.Column<string>(nullable: true),
                    Venue = table.Column<string>(nullable: true),
                    VenueID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pitchers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pitchers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PositionPlayers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AwayAb = table.Column<int>(nullable: false),
                    AwayAvg = table.Column<decimal>(nullable: false),
                    AwayCs = table.Column<int>(nullable: false),
                    AwayHit = table.Column<int>(nullable: false),
                    AwayHr = table.Column<int>(nullable: false),
                    AwayOps = table.Column<decimal>(nullable: false),
                    AwayRbi = table.Column<int>(nullable: false),
                    AwayRun = table.Column<int>(nullable: false),
                    AwaySb = table.Column<int>(nullable: false),
                    AwayWalk = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    HomeAb = table.Column<int>(nullable: false),
                    HomeAvg = table.Column<decimal>(nullable: false),
                    HomeCs = table.Column<int>(nullable: false),
                    HomeHit = table.Column<int>(nullable: false),
                    HomeHr = table.Column<int>(nullable: false),
                    HomeOps = table.Column<decimal>(nullable: false),
                    HomeRbi = table.Column<int>(nullable: false),
                    HomeRun = table.Column<int>(nullable: false),
                    HomeSb = table.Column<int>(nullable: false),
                    HomeWalk = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    MonthAb = table.Column<int>(nullable: false),
                    MonthAvg = table.Column<decimal>(nullable: false),
                    MonthCs = table.Column<int>(nullable: false),
                    MonthHit = table.Column<int>(nullable: false),
                    MonthHr = table.Column<int>(nullable: false),
                    MonthOps = table.Column<decimal>(nullable: false),
                    MonthRbi = table.Column<int>(nullable: false),
                    MonthRun = table.Column<int>(nullable: false),
                    MonthSb = table.Column<int>(nullable: false),
                    MonthWalk = table.Column<int>(nullable: false),
                    PitchHates = table.Column<string>(nullable: true),
                    PitchLoves = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    SeasonAb = table.Column<int>(nullable: false),
                    SeasonAvg = table.Column<decimal>(nullable: false),
                    SeasonCs = table.Column<int>(nullable: false),
                    SeasonHit = table.Column<int>(nullable: false),
                    SeasonHr = table.Column<int>(nullable: false),
                    SeasonOps = table.Column<decimal>(nullable: false),
                    SeasonRbi = table.Column<int>(nullable: false),
                    SeasonRun = table.Column<int>(nullable: false),
                    SeasonSb = table.Column<int>(nullable: false),
                    SeasonWalk = table.Column<int>(nullable: false),
                    TeamName = table.Column<string>(nullable: true),
                    VsLhpAb = table.Column<int>(nullable: false),
                    VsLhpAvg = table.Column<decimal>(nullable: false),
                    VsLhpCs = table.Column<int>(nullable: false),
                    VsLhpHit = table.Column<int>(nullable: false),
                    VsLhpHr = table.Column<int>(nullable: false),
                    VsLhpOps = table.Column<decimal>(nullable: false),
                    VsLhpRbi = table.Column<int>(nullable: false),
                    VsLhpRun = table.Column<int>(nullable: false),
                    VsLhpSb = table.Column<int>(nullable: false),
                    VsLhpWalk = table.Column<int>(nullable: false),
                    VsRhpAb = table.Column<int>(nullable: false),
                    VsRhpAvg = table.Column<decimal>(nullable: false),
                    VsRhpCs = table.Column<int>(nullable: false),
                    VsRhpHit = table.Column<int>(nullable: false),
                    VsRhpHr = table.Column<int>(nullable: false),
                    VsRhpOps = table.Column<decimal>(nullable: false),
                    VsRhpRbi = table.Column<int>(nullable: false),
                    VsRhpRun = table.Column<int>(nullable: false),
                    VsRhpSb = table.Column<int>(nullable: false),
                    VsRhpWalk = table.Column<int>(nullable: false),
                    VsStarterAb = table.Column<int>(nullable: false),
                    VsStarterAvg = table.Column<decimal>(nullable: false),
                    VsStarterCs = table.Column<int>(nullable: false),
                    VsStarterHit = table.Column<int>(nullable: false),
                    VsStarterHr = table.Column<int>(nullable: false),
                    VsStarterOps = table.Column<decimal>(nullable: false),
                    VsStarterRbi = table.Column<int>(nullable: false),
                    VsStarterRun = table.Column<int>(nullable: false),
                    VsStarterSb = table.Column<int>(nullable: false),
                    VsStarterWalk = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionPlayers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectedTeams",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PitcherID = table.Column<int>(nullable: false),
                    PositionPlayerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectedTeams", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProjectedTeams_Pitchers_PitcherID",
                        column: x => x.PitcherID,
                        principalTable: "Pitchers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectedTeams_PositionPlayers_PositionPlayerID",
                        column: x => x.PositionPlayerID,
                        principalTable: "PositionPlayers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectedTeams_PitcherID",
                table: "ProjectedTeams",
                column: "PitcherID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectedTeams_PositionPlayerID",
                table: "ProjectedTeams",
                column: "PositionPlayerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "ProjectedTeams");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Pitchers");

            migrationBuilder.DropTable(
                name: "PositionPlayers");
        }
    }
}

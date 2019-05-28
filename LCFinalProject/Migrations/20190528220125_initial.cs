using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LCFinalProject.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Batters",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AtBats = table.Column<int>(nullable: false),
                    CS = table.Column<int>(nullable: false),
                    DistanceAvg = table.Column<decimal>(nullable: false),
                    Doubles = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    Hits = table.Column<int>(nullable: false),
                    HomeRuns = table.Column<int>(nullable: false),
                    LastFiveAb = table.Column<int>(nullable: false),
                    LastFiveDouble = table.Column<int>(nullable: false),
                    LastFiveHR = table.Column<int>(nullable: false),
                    LastFiveRBI = table.Column<int>(nullable: false),
                    LastFiveRuns = table.Column<int>(nullable: false),
                    LastFiveSB = table.Column<int>(nullable: false),
                    LastFiveSingle = table.Column<int>(nullable: false),
                    LastFiveTriple = table.Column<int>(nullable: false),
                    LastFiveWalk = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    LastTenLaunchAvg = table.Column<decimal>(nullable: false),
                    LastTenSpeedAvg = table.Column<decimal>(nullable: false),
                    PlayerID = table.Column<int>(nullable: false),
                    RBIs = table.Column<int>(nullable: false),
                    Runs = table.Column<int>(nullable: false),
                    SB = table.Column<int>(nullable: false),
                    TeamName = table.Column<string>(nullable: true),
                    Triples = table.Column<int>(nullable: false),
                    Walks = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batters", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GameDate = table.Column<DateTime>(nullable: false),
                    GameID = table.Column<int>(nullable: false),
                    Venue = table.Column<string>(nullable: true),
                    VenueID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GameStats",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CS = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Doubles = table.Column<int>(nullable: false),
                    Hits = table.Column<int>(nullable: false),
                    HomeRuns = table.Column<int>(nullable: false),
                    PlayerID = table.Column<int>(nullable: false),
                    RBIs = table.Column<int>(nullable: false),
                    Runs = table.Column<int>(nullable: false),
                    SB = table.Column<int>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    Triples = table.Column<int>(nullable: false),
                    Walks = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameStats", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HitDatas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Distance = table.Column<decimal>(nullable: false),
                    LaunchAngle = table.Column<decimal>(nullable: false),
                    LaunchSpeed = table.Column<decimal>(nullable: false),
                    PlayerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HitDatas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PitchDatas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PitchDatas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PitcherGameStats",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BattersFaced = table.Column<int>(nullable: false),
                    CS = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Doubles = table.Column<int>(nullable: false),
                    EarnedRuns = table.Column<int>(nullable: false),
                    FlyOuts = table.Column<int>(nullable: false),
                    GroundOuts = table.Column<int>(nullable: false),
                    Hits = table.Column<int>(nullable: false),
                    HomeRuns = table.Column<int>(nullable: false),
                    OpponentScore = table.Column<int>(nullable: false),
                    PitchesThrown = table.Column<int>(nullable: false),
                    PlayerID = table.Column<int>(nullable: false),
                    RBIs = table.Column<int>(nullable: false),
                    Runs = table.Column<int>(nullable: false),
                    SB = table.Column<int>(nullable: false),
                    Score = table.Column<decimal>(nullable: false),
                    Triples = table.Column<int>(nullable: false),
                    Walks = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PitcherGameStats", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pitchers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CS = table.Column<int>(nullable: false),
                    Doubles = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    Hits = table.Column<int>(nullable: false),
                    HomeRuns = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    RBIs = table.Column<int>(nullable: false),
                    Runs = table.Column<int>(nullable: false),
                    SB = table.Column<int>(nullable: false),
                    TeamName = table.Column<string>(nullable: true),
                    Triples = table.Column<int>(nullable: false),
                    Walks = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pitchers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeamName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Batters");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "GameStats");

            migrationBuilder.DropTable(
                name: "HitDatas");

            migrationBuilder.DropTable(
                name: "PitchDatas");

            migrationBuilder.DropTable(
                name: "PitcherGameStats");

            migrationBuilder.DropTable(
                name: "Pitchers");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}

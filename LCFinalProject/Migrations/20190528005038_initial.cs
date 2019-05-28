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
                name: "Pitchers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AwayEarnedRunsAllowed = table.Column<decimal>(nullable: false),
                    AwayHitByPitch = table.Column<int>(nullable: false),
                    AwayHitsAllowed = table.Column<int>(nullable: false),
                    AwayHomeRunAllowed = table.Column<int>(nullable: false),
                    AwayIp = table.Column<decimal>(nullable: false),
                    AwayPointsPerIP = table.Column<decimal>(nullable: false),
                    AwayRunsAllowed = table.Column<int>(nullable: false),
                    AwayStrikeOuts = table.Column<int>(nullable: false),
                    AwayTotalScore = table.Column<decimal>(nullable: false),
                    AwayWalks = table.Column<int>(nullable: false),
                    DKID = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    HomeAway = table.Column<string>(nullable: true),
                    HomeEarnedRunsAllowed = table.Column<decimal>(nullable: false),
                    HomeHitByPitch = table.Column<int>(nullable: false),
                    HomeHitsAllowed = table.Column<int>(nullable: false),
                    HomeHomeRunAllowed = table.Column<int>(nullable: false),
                    HomeIp = table.Column<decimal>(nullable: false),
                    HomePointsPerIP = table.Column<decimal>(nullable: false),
                    HomeRunsAllowed = table.Column<int>(nullable: false),
                    HomeStrikeOuts = table.Column<int>(nullable: false),
                    HomeTotalScore = table.Column<decimal>(nullable: false),
                    HomeWalks = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    LastStartDeviance = table.Column<decimal>(nullable: false),
                    LastStartProjected = table.Column<decimal>(nullable: false),
                    LastStartScore = table.Column<decimal>(nullable: false),
                    LastThreeDeviance = table.Column<decimal>(nullable: false),
                    LastThreeERA = table.Column<int>(nullable: false),
                    LastThreeHRA = table.Column<int>(nullable: false),
                    LastThreeHitsAllowed = table.Column<int>(nullable: false),
                    LastThreeInningsPitched = table.Column<decimal>(nullable: false),
                    LastThreeProjected = table.Column<decimal>(nullable: false),
                    LastThreeStrikeouts = table.Column<int>(nullable: false),
                    LastThreeTotalScore = table.Column<decimal>(nullable: false),
                    LastThreeWalks = table.Column<int>(nullable: false),
                    MatchUp = table.Column<string>(nullable: true),
                    Opponent = table.Column<string>(nullable: true),
                    OpposingTeamProjected = table.Column<decimal>(nullable: false),
                    PlayerID = table.Column<int>(nullable: false),
                    ProbableStarter = table.Column<bool>(nullable: false),
                    ProjectedHRA = table.Column<decimal>(nullable: false),
                    ProjectedHit = table.Column<decimal>(nullable: false),
                    ProjectedRA = table.Column<decimal>(nullable: false),
                    ProjectedStrikeout = table.Column<decimal>(nullable: false),
                    ProjectedWalk = table.Column<decimal>(nullable: false),
                    Projection = table.Column<int>(nullable: false),
                    Salary = table.Column<int>(nullable: false),
                    SeasonEarnedRunsAllowed = table.Column<decimal>(nullable: false),
                    SeasonHitsAllowed = table.Column<int>(nullable: false),
                    SeasonHomeRunAllowed = table.Column<int>(nullable: false),
                    SeasonIp = table.Column<decimal>(nullable: false),
                    SeasonPointsPerIP = table.Column<decimal>(nullable: false),
                    SeasonRunsAllowed = table.Column<int>(nullable: false),
                    SeasonStrikeOuts = table.Column<int>(nullable: false),
                    SeasonTotalScore = table.Column<decimal>(nullable: false),
                    SeasonWalks = table.Column<int>(nullable: false),
                    SeasonWins = table.Column<int>(nullable: false),
                    TeamName = table.Column<string>(nullable: true),
                    ThrowingHand = table.Column<string>(nullable: true)
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
                name: "Pitchers");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}

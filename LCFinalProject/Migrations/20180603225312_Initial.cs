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
                name: "IndividualGamePitchers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompleteGame = table.Column<int>(nullable: false),
                    CompleteGameShutOut = table.Column<int>(nullable: false),
                    EarnedRuns = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    GameDate = table.Column<DateTime>(nullable: false),
                    HitsAllowed = table.Column<int>(nullable: false),
                    HomeRunsAllowed = table.Column<int>(nullable: false),
                    IP = table.Column<decimal>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    Losses = table.Column<int>(nullable: false),
                    PlayerID = table.Column<int>(nullable: false),
                    RunsAllowed = table.Column<int>(nullable: false),
                    StrikeOuts = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false),
                    Walks = table.Column<int>(nullable: false),
                    Wins = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualGamePitchers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "IndividualGamePosPlayers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ab = table.Column<int>(nullable: false),
                    CaughtStealing = table.Column<int>(nullable: false),
                    Double = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    GameDate = table.Column<DateTime>(nullable: false),
                    HomeRun = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    Position = table.Column<string>(nullable: true),
                    RBI = table.Column<int>(nullable: false),
                    Run = table.Column<int>(nullable: false),
                    Single = table.Column<int>(nullable: false),
                    StolenBase = table.Column<int>(nullable: false),
                    StrikeOut = table.Column<int>(nullable: false),
                    Team = table.Column<string>(nullable: true),
                    TotalScore = table.Column<decimal>(nullable: false),
                    Triple = table.Column<int>(nullable: false),
                    Walk = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualGamePosPlayers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LastFiveGamesTeams",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HomeRunTotal = table.Column<int>(nullable: false),
                    RunTotal = table.Column<int>(nullable: false),
                    StrikeOutTotal = table.Column<int>(nullable: false),
                    TeamName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LastFiveGamesTeams", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LastTenGamesPosPlayers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AvgAtBat = table.Column<decimal>(nullable: false),
                    AvgCaughtStealing = table.Column<decimal>(nullable: false),
                    AvgDouble = table.Column<decimal>(nullable: false),
                    AvgHBP = table.Column<decimal>(nullable: false),
                    AvgHomeRun = table.Column<decimal>(nullable: false),
                    AvgRBI = table.Column<decimal>(nullable: false),
                    AvgResults = table.Column<decimal>(nullable: false),
                    AvgRun = table.Column<decimal>(nullable: false),
                    AvgSingle = table.Column<decimal>(nullable: false),
                    AvgStolenBase = table.Column<decimal>(nullable: false),
                    AvgTriple = table.Column<decimal>(nullable: false),
                    AvgWalk = table.Column<decimal>(nullable: false),
                    DateEntered = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    GamesPlayed = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    Position = table.Column<string>(nullable: true),
                    Team = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LastTenGamesPosPlayers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LastThreeGamesPitchers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AvgCompleteGame = table.Column<decimal>(nullable: false),
                    AvgCompleteGameShutOut = table.Column<decimal>(nullable: false),
                    AvgEarnedRun = table.Column<decimal>(nullable: false),
                    AvgHitAllowed = table.Column<decimal>(nullable: false),
                    AvgHomeRunAllowed = table.Column<decimal>(nullable: false),
                    AvgIP = table.Column<decimal>(nullable: false),
                    AvgLoss = table.Column<decimal>(nullable: false),
                    AvgResults = table.Column<decimal>(nullable: false),
                    AvgRunAllowed = table.Column<decimal>(nullable: false),
                    AvgStrikeOut = table.Column<decimal>(nullable: false),
                    AvgWalkAllowed = table.Column<decimal>(nullable: false),
                    AvgWin = table.Column<decimal>(nullable: false),
                    DateEntered = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    GamesPlayed = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LastThreeGamesPitchers", x => x.ID);
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
                    LastStartScore = table.Column<decimal>(nullable: false),
                    LastThreeERA = table.Column<int>(nullable: false),
                    LastThreeHRA = table.Column<int>(nullable: false),
                    LastThreeHitsAllowed = table.Column<int>(nullable: false),
                    LastThreeInningsPitched = table.Column<decimal>(nullable: false),
                    LastThreeStrikeouts = table.Column<int>(nullable: false),
                    LastThreeTotalScore = table.Column<decimal>(nullable: false),
                    LastThreeWalks = table.Column<int>(nullable: false),
                    MatchUp = table.Column<string>(nullable: true),
                    Opponent = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    ProbableStarter = table.Column<bool>(nullable: false),
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
                name: "PositionPlayer",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AwayAb = table.Column<decimal>(nullable: false),
                    AwayAvg = table.Column<decimal>(nullable: false),
                    AwayCs = table.Column<int>(nullable: false),
                    AwayHit = table.Column<int>(nullable: false),
                    AwayHr = table.Column<int>(nullable: false),
                    AwayOps = table.Column<decimal>(nullable: false),
                    AwayRbi = table.Column<int>(nullable: false),
                    AwayRun = table.Column<int>(nullable: false),
                    AwaySb = table.Column<int>(nullable: false),
                    AwayScorePerAB = table.Column<decimal>(nullable: false),
                    AwayTotalScore = table.Column<decimal>(nullable: false),
                    AwayWalk = table.Column<int>(nullable: false),
                    DKID = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    HomeAb = table.Column<decimal>(nullable: false),
                    HomeAvg = table.Column<decimal>(nullable: false),
                    HomeAway = table.Column<string>(nullable: true),
                    HomeCs = table.Column<int>(nullable: false),
                    HomeHit = table.Column<int>(nullable: false),
                    HomeHr = table.Column<int>(nullable: false),
                    HomeOps = table.Column<decimal>(nullable: false),
                    HomeRbi = table.Column<int>(nullable: false),
                    HomeRun = table.Column<int>(nullable: false),
                    HomeSb = table.Column<int>(nullable: false),
                    HomeScorePerAB = table.Column<decimal>(nullable: false),
                    HomeTotalScore = table.Column<decimal>(nullable: false),
                    HomeWalk = table.Column<int>(nullable: false),
                    LastFiveAb = table.Column<int>(nullable: false),
                    LastFiveDouble = table.Column<int>(nullable: false),
                    LastFiveHR = table.Column<int>(nullable: false),
                    LastFiveHit = table.Column<int>(nullable: false),
                    LastFiveRBI = table.Column<int>(nullable: false),
                    LastFiveRuns = table.Column<int>(nullable: false),
                    LastFiveSB = table.Column<int>(nullable: false),
                    LastFiveTotalScore = table.Column<decimal>(nullable: false),
                    LastFiveTriple = table.Column<int>(nullable: false),
                    LastFiveWalk = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    MatchUp = table.Column<string>(nullable: true),
                    OpponentHRALastThree = table.Column<int>(nullable: false),
                    OpponentPointsLastThree = table.Column<decimal>(nullable: false),
                    OpponentStarter = table.Column<string>(nullable: true),
                    OpponentThrowingHand = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    Position = table.Column<string>(nullable: true),
                    Projection = table.Column<decimal>(nullable: false),
                    Salary = table.Column<int>(nullable: false),
                    SeasonAb = table.Column<decimal>(nullable: false),
                    SeasonAvg = table.Column<decimal>(nullable: false),
                    SeasonCs = table.Column<int>(nullable: false),
                    SeasonDouble = table.Column<int>(nullable: false),
                    SeasonHit = table.Column<int>(nullable: false),
                    SeasonHr = table.Column<int>(nullable: false),
                    SeasonOps = table.Column<decimal>(nullable: false),
                    SeasonRbi = table.Column<int>(nullable: false),
                    SeasonRun = table.Column<int>(nullable: false),
                    SeasonSb = table.Column<int>(nullable: false),
                    SeasonSingle = table.Column<int>(nullable: false),
                    SeasonTotalScore = table.Column<decimal>(nullable: false),
                    SeasonTriple = table.Column<int>(nullable: false),
                    SeasonWalk = table.Column<int>(nullable: false),
                    TeamName = table.Column<string>(nullable: true),
                    VsLhpAb = table.Column<decimal>(nullable: false),
                    VsLhpAvg = table.Column<decimal>(nullable: false),
                    VsLhpCs = table.Column<int>(nullable: false),
                    VsLhpHit = table.Column<int>(nullable: false),
                    VsLhpHr = table.Column<int>(nullable: false),
                    VsLhpOps = table.Column<decimal>(nullable: false),
                    VsLhpRbi = table.Column<int>(nullable: false),
                    VsLhpRun = table.Column<int>(nullable: false),
                    VsLhpSb = table.Column<int>(nullable: false),
                    VsLhpScorePerAB = table.Column<decimal>(nullable: false),
                    VsLhpTotalScore = table.Column<decimal>(nullable: false),
                    VsLhpWalk = table.Column<int>(nullable: false),
                    VsRhpAb = table.Column<decimal>(nullable: false),
                    VsRhpAvg = table.Column<decimal>(nullable: false),
                    VsRhpCs = table.Column<int>(nullable: false),
                    VsRhpHit = table.Column<int>(nullable: false),
                    VsRhpHr = table.Column<int>(nullable: false),
                    VsRhpOps = table.Column<decimal>(nullable: false),
                    VsRhpRbi = table.Column<int>(nullable: false),
                    VsRhpRun = table.Column<int>(nullable: false),
                    VsRhpSb = table.Column<int>(nullable: false),
                    VsRhpScorePerAB = table.Column<decimal>(nullable: false),
                    VsRhpTotalScore = table.Column<decimal>(nullable: false),
                    VsRhpWalk = table.Column<int>(nullable: false),
                    YesterdayTotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionPlayer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectedTeams",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Catcher = table.Column<string>(nullable: true),
                    CatcherProjection = table.Column<decimal>(nullable: false),
                    CatcherSalary = table.Column<int>(nullable: false),
                    FirstBase = table.Column<string>(nullable: true),
                    FirstBaseProjection = table.Column<decimal>(nullable: false),
                    FirstBaseSalary = table.Column<int>(nullable: false),
                    OutfieldOne = table.Column<string>(nullable: true),
                    OutfieldOneProjection = table.Column<decimal>(nullable: false),
                    OutfieldOneSalary = table.Column<int>(nullable: false),
                    OutfieldThree = table.Column<string>(nullable: true),
                    OutfieldThreeProjection = table.Column<int>(nullable: false),
                    OutfieldThreeSalary = table.Column<int>(nullable: false),
                    OutfieldTwo = table.Column<string>(nullable: true),
                    OutfieldTwoProjection = table.Column<decimal>(nullable: false),
                    OutfieldTwoSalary = table.Column<int>(nullable: false),
                    PitcherOne = table.Column<string>(nullable: true),
                    PitcherOneProjection = table.Column<decimal>(nullable: false),
                    PitcherOneSalary = table.Column<int>(nullable: false),
                    PitcherTwo = table.Column<string>(nullable: true),
                    PitcherTwoProjection = table.Column<decimal>(nullable: false),
                    PitcherTwoSalary = table.Column<int>(nullable: false),
                    SecondBase = table.Column<string>(nullable: true),
                    SecondBaseProjection = table.Column<decimal>(nullable: false),
                    SecondBaseSalary = table.Column<int>(nullable: false),
                    Shortstop = table.Column<string>(nullable: true),
                    ShortstopProjection = table.Column<decimal>(nullable: false),
                    ShortstopSalary = table.Column<int>(nullable: false),
                    TeamProjection = table.Column<decimal>(nullable: false),
                    ThirdBase = table.Column<string>(nullable: true),
                    ThirdBaseProjection = table.Column<decimal>(nullable: false),
                    ThirdBaseSalary = table.Column<int>(nullable: false),
                    TotalCost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectedTeams", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GamesPlayedGauge = table.Column<decimal>(nullable: false),
                    Hits = table.Column<int>(nullable: false),
                    HitsAllowed = table.Column<decimal>(nullable: false),
                    HomeAway = table.Column<string>(nullable: true),
                    HomeRuns = table.Column<int>(nullable: false),
                    HomeRunsAllowed = table.Column<decimal>(nullable: false),
                    Opponent = table.Column<string>(nullable: true),
                    OpponentStarter = table.Column<string>(nullable: true),
                    PointsGivenUp = table.Column<decimal>(nullable: false),
                    PointsPerPitcherUsed = table.Column<decimal>(nullable: false),
                    Runs = table.Column<int>(nullable: false),
                    RunsAllowed = table.Column<decimal>(nullable: false),
                    Starter = table.Column<string>(nullable: true),
                    StrikeOuts = table.Column<int>(nullable: false),
                    TeamName = table.Column<string>(nullable: true),
                    TotalPoints = table.Column<int>(nullable: false),
                    Walks = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.ID);
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "IndividualGamePitchers");

            migrationBuilder.DropTable(
                name: "IndividualGamePosPlayers");

            migrationBuilder.DropTable(
                name: "LastFiveGamesTeams");

            migrationBuilder.DropTable(
                name: "LastTenGamesPosPlayers");

            migrationBuilder.DropTable(
                name: "LastThreeGamesPitchers");

            migrationBuilder.DropTable(
                name: "Pitchers");

            migrationBuilder.DropTable(
                name: "PositionPlayer");

            migrationBuilder.DropTable(
                name: "ProjectedTeams");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

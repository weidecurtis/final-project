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
                name: "AwayCatchers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwayCatchers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AwayFirstBasemen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwayFirstBasemen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AwayOutfielders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwayOutfielders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AwayPitchers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwayPitchers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AwaySecondBasemen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwaySecondBasemen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AwayShortstops",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwayShortstops", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AwayThirdBasemen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwayThirdBasemen", x => x.ID);
                });

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
                name: "HomeCatchers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeCatchers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HomeFirstBasemen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeFirstBasemen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HomeOutfielders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeOutfielders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HomePitchers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePitchers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HomeSecondBasemen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeSecondBasemen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HomeShortstops",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeShortstops", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HomeThirdBasemen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeThirdBasemen", x => x.ID);
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
                    Triple = table.Column<int>(nullable: false),
                    Walk = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualGamePosPlayers", x => x.ID);
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
                    Position = table.Column<string>(nullable: true)
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
                name: "LhpCatchers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LhpCatchers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LhpFirstBasemen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LhpFirstBasemen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LhpOutfielders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LhpOutfielders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LhpSecondBasemen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LhpSecondBasemen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LhpShortstops",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LhpShortstops", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LhpThirdBasemen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LhpThirdBasemen", x => x.ID);
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
                    AwayRunsAllowed = table.Column<int>(nullable: false),
                    AwayStrikeOuts = table.Column<int>(nullable: false),
                    AwayWalks = table.Column<int>(nullable: false),
                    DkID = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    HomeEarnedRunsAllowed = table.Column<decimal>(nullable: false),
                    HomeHitByPitch = table.Column<int>(nullable: false),
                    HomeHitsAllowed = table.Column<int>(nullable: false),
                    HomeHomeRunAllowed = table.Column<int>(nullable: false),
                    HomeIp = table.Column<decimal>(nullable: false),
                    HomeRunsAllowed = table.Column<int>(nullable: false),
                    HomeStrikeOuts = table.Column<int>(nullable: false),
                    HomeWalks = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    SeasonEarnedRunsAllowed = table.Column<decimal>(nullable: false),
                    SeasonHitsAllowed = table.Column<int>(nullable: false),
                    SeasonHomeRunAllowed = table.Column<int>(nullable: false),
                    SeasonIp = table.Column<decimal>(nullable: false),
                    SeasonRunsAllowed = table.Column<int>(nullable: false),
                    SeasonStrikeOuts = table.Column<int>(nullable: false),
                    SeasonWalks = table.Column<int>(nullable: false),
                    TeamName = table.Column<string>(nullable: true)
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
                    DkID = table.Column<int>(nullable: false),
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
                    PlayerID = table.Column<int>(nullable: false),
                    Position = table.Column<string>(nullable: true),
                    SeasonAb = table.Column<int>(nullable: false),
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
                    SeasonTriple = table.Column<int>(nullable: false),
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
                name: "ProjectedCatchers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    ProjectedScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectedCatchers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectedFirstBasemen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    ProjectedScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectedFirstBasemen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectedOutfielders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    ProjectedScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectedOutfielders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectedPitchers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    ProjectedScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectedPitchers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectedSecondBasemen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    ProjectedScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectedSecondBasemen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectedShortstops",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    ProjectedScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectedShortstops", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectedTeams",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CatcherName = table.Column<string>(nullable: true),
                    CatcherPrice = table.Column<int>(nullable: false),
                    CatcherProjectedScore = table.Column<decimal>(nullable: false),
                    FirstBaseName = table.Column<string>(nullable: true),
                    FirstBasePrice = table.Column<int>(nullable: false),
                    FirstBaseProjectScore = table.Column<decimal>(nullable: false),
                    OutfieldOneName = table.Column<string>(nullable: true),
                    OutfieldOnePrice = table.Column<int>(nullable: false),
                    OutfieldOneProjectedScore = table.Column<decimal>(nullable: false),
                    OutfieldThreeName = table.Column<string>(nullable: true),
                    OutfieldThreePrice = table.Column<int>(nullable: false),
                    OutfieldThreeProjectedScore = table.Column<decimal>(nullable: false),
                    OutfieldTwoName = table.Column<string>(nullable: true),
                    OutfieldTwoPrice = table.Column<int>(nullable: false),
                    OutfieldTwoProjectedScore = table.Column<decimal>(nullable: false),
                    PitcherOneName = table.Column<string>(nullable: true),
                    PitcherOnePrice = table.Column<int>(nullable: false),
                    PitcherOneProjectedScore = table.Column<decimal>(nullable: false),
                    PitcherTwoName = table.Column<string>(nullable: true),
                    PitcherTwoPrice = table.Column<int>(nullable: false),
                    PitcherTwoProjectedScore = table.Column<decimal>(nullable: false),
                    Position = table.Column<string>(nullable: true),
                    ProjectedResults = table.Column<decimal>(nullable: false),
                    SecondBaseName = table.Column<string>(nullable: true),
                    SecondBasePrice = table.Column<int>(nullable: false),
                    SecondBaseProjectedScore = table.Column<decimal>(nullable: false),
                    ShortStopName = table.Column<string>(nullable: true),
                    ShortStopPrice = table.Column<int>(nullable: false),
                    ShortStopProjectedScore = table.Column<decimal>(nullable: false),
                    ThirdBaseName = table.Column<string>(nullable: true),
                    ThirdBasePrice = table.Column<int>(nullable: false),
                    ThirdBaseProjectedScore = table.Column<decimal>(nullable: false),
                    TotalProjectedScore = table.Column<decimal>(nullable: false),
                    TotalTeamPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectedTeams", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectedThirdBasemen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    ProjectedScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectedThirdBasemen", x => x.ID);
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
                name: "RhpCatchers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RhpCatchers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RhpFirstBasemen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RhpFirstBasemen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RhpOutfielders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RhpOutfielders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RhpSecondBasemen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RhpSecondBasemen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RhpShortstops",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RhpShortstops", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RhpThirdBasemen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PlayerID = table.Column<int>(nullable: false),
                    TotalScore = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RhpThirdBasemen", x => x.ID);
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
                name: "AwayCatchers");

            migrationBuilder.DropTable(
                name: "AwayFirstBasemen");

            migrationBuilder.DropTable(
                name: "AwayOutfielders");

            migrationBuilder.DropTable(
                name: "AwayPitchers");

            migrationBuilder.DropTable(
                name: "AwaySecondBasemen");

            migrationBuilder.DropTable(
                name: "AwayShortstops");

            migrationBuilder.DropTable(
                name: "AwayThirdBasemen");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "HomeCatchers");

            migrationBuilder.DropTable(
                name: "HomeFirstBasemen");

            migrationBuilder.DropTable(
                name: "HomeOutfielders");

            migrationBuilder.DropTable(
                name: "HomePitchers");

            migrationBuilder.DropTable(
                name: "HomeSecondBasemen");

            migrationBuilder.DropTable(
                name: "HomeShortstops");

            migrationBuilder.DropTable(
                name: "HomeThirdBasemen");

            migrationBuilder.DropTable(
                name: "IndividualGamePitchers");

            migrationBuilder.DropTable(
                name: "IndividualGamePosPlayers");

            migrationBuilder.DropTable(
                name: "LastTenGamesPosPlayers");

            migrationBuilder.DropTable(
                name: "LastThreeGamesPitchers");

            migrationBuilder.DropTable(
                name: "LhpCatchers");

            migrationBuilder.DropTable(
                name: "LhpFirstBasemen");

            migrationBuilder.DropTable(
                name: "LhpOutfielders");

            migrationBuilder.DropTable(
                name: "LhpSecondBasemen");

            migrationBuilder.DropTable(
                name: "LhpShortstops");

            migrationBuilder.DropTable(
                name: "LhpThirdBasemen");

            migrationBuilder.DropTable(
                name: "Pitchers");

            migrationBuilder.DropTable(
                name: "PositionPlayers");

            migrationBuilder.DropTable(
                name: "ProjectedCatchers");

            migrationBuilder.DropTable(
                name: "ProjectedFirstBasemen");

            migrationBuilder.DropTable(
                name: "ProjectedOutfielders");

            migrationBuilder.DropTable(
                name: "ProjectedPitchers");

            migrationBuilder.DropTable(
                name: "ProjectedSecondBasemen");

            migrationBuilder.DropTable(
                name: "ProjectedShortstops");

            migrationBuilder.DropTable(
                name: "ProjectedTeams");

            migrationBuilder.DropTable(
                name: "ProjectedThirdBasemen");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "RhpCatchers");

            migrationBuilder.DropTable(
                name: "RhpFirstBasemen");

            migrationBuilder.DropTable(
                name: "RhpOutfielders");

            migrationBuilder.DropTable(
                name: "RhpSecondBasemen");

            migrationBuilder.DropTable(
                name: "RhpShortstops");

            migrationBuilder.DropTable(
                name: "RhpThirdBasemen");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

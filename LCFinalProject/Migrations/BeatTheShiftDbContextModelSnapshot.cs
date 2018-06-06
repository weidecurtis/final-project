﻿// <auto-generated />
using LCFinalProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace LCFinalProject.Migrations
{
    [DbContext(typeof(BeatTheShiftDbContext))]
    partial class BeatTheShiftDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LCFinalProject.Models.IndividualGamePitcher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CompleteGame");

                    b.Property<int>("CompleteGameShutOut");

                    b.Property<int>("EarnedRuns");

                    b.Property<string>("FirstName");

                    b.Property<DateTime>("GameDate");

                    b.Property<int>("HitsAllowed");

                    b.Property<int>("HomeRunsAllowed");

                    b.Property<decimal>("IP");

                    b.Property<string>("LastName");

                    b.Property<int>("Losses");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("ProjectedScore");

                    b.Property<int>("RunsAllowed");

                    b.Property<int>("StrikeOuts");

                    b.Property<string>("TeamName");

                    b.Property<decimal>("TotalScore");

                    b.Property<int>("Walks");

                    b.Property<int>("Wins");

                    b.HasKey("ID");

                    b.ToTable("IndividualGamePitchers");
                });

            modelBuilder.Entity("LCFinalProject.Models.IndividualGamePosPlayer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Ab");

                    b.Property<int>("CaughtStealing");

                    b.Property<int>("Double");

                    b.Property<string>("FirstName");

                    b.Property<DateTime>("GameDate");

                    b.Property<int>("HomeRun");

                    b.Property<string>("LastName");

                    b.Property<bool>("Played");

                    b.Property<int>("PlayerID");

                    b.Property<string>("Position");

                    b.Property<decimal>("Projection");

                    b.Property<int>("RBI");

                    b.Property<int>("Run");

                    b.Property<int>("Single");

                    b.Property<int>("StolenBase");

                    b.Property<int>("StrikeOut");

                    b.Property<string>("Team");

                    b.Property<decimal>("TotalScore");

                    b.Property<int>("Triple");

                    b.Property<int>("Walk");

                    b.HasKey("ID");

                    b.ToTable("IndividualGamePosPlayers");
                });

            modelBuilder.Entity("LCFinalProject.Models.LastFiveGamesTeam", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HomeRunTotal");

                    b.Property<int>("RunTotal");

                    b.Property<int>("StrikeOutTotal");

                    b.Property<string>("TeamName");

                    b.HasKey("ID");

                    b.ToTable("LastFiveGamesTeams");
                });

            modelBuilder.Entity("LCFinalProject.Models.LastTenGamesPosPlayer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AvgAtBat");

                    b.Property<decimal>("AvgCaughtStealing");

                    b.Property<decimal>("AvgDouble");

                    b.Property<decimal>("AvgHBP");

                    b.Property<decimal>("AvgHomeRun");

                    b.Property<decimal>("AvgRBI");

                    b.Property<decimal>("AvgResults");

                    b.Property<decimal>("AvgRun");

                    b.Property<decimal>("AvgSingle");

                    b.Property<decimal>("AvgStolenBase");

                    b.Property<decimal>("AvgTriple");

                    b.Property<decimal>("AvgWalk");

                    b.Property<DateTime>("DateEntered");

                    b.Property<string>("FirstName");

                    b.Property<int>("GamesPlayed");

                    b.Property<string>("LastName");

                    b.Property<int>("PlayerID");

                    b.Property<string>("Position");

                    b.Property<string>("Team");

                    b.HasKey("ID");

                    b.ToTable("LastTenGamesPosPlayers");
                });

            modelBuilder.Entity("LCFinalProject.Models.LastThreeGamesPitcher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AvgCompleteGame");

                    b.Property<decimal>("AvgCompleteGameShutOut");

                    b.Property<decimal>("AvgEarnedRun");

                    b.Property<decimal>("AvgHitAllowed");

                    b.Property<decimal>("AvgHomeRunAllowed");

                    b.Property<decimal>("AvgIP");

                    b.Property<decimal>("AvgLoss");

                    b.Property<decimal>("AvgResults");

                    b.Property<decimal>("AvgRunAllowed");

                    b.Property<decimal>("AvgStrikeOut");

                    b.Property<decimal>("AvgWalkAllowed");

                    b.Property<decimal>("AvgWin");

                    b.Property<DateTime>("DateEntered");

                    b.Property<string>("FirstName");

                    b.Property<int>("GamesPlayed");

                    b.Property<string>("LastName");

                    b.Property<int>("PlayerID");

                    b.HasKey("ID");

                    b.ToTable("LastThreeGamesPitchers");
                });

            modelBuilder.Entity("LCFinalProject.Models.Pitcher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AwayEarnedRunsAllowed");

                    b.Property<int>("AwayHitByPitch");

                    b.Property<int>("AwayHitsAllowed");

                    b.Property<int>("AwayHomeRunAllowed");

                    b.Property<decimal>("AwayIp");

                    b.Property<decimal>("AwayPointsPerIP");

                    b.Property<int>("AwayRunsAllowed");

                    b.Property<int>("AwayStrikeOuts");

                    b.Property<decimal>("AwayTotalScore");

                    b.Property<int>("AwayWalks");

                    b.Property<int>("DKID");

                    b.Property<string>("FirstName");

                    b.Property<string>("HomeAway");

                    b.Property<decimal>("HomeEarnedRunsAllowed");

                    b.Property<int>("HomeHitByPitch");

                    b.Property<int>("HomeHitsAllowed");

                    b.Property<int>("HomeHomeRunAllowed");

                    b.Property<decimal>("HomeIp");

                    b.Property<decimal>("HomePointsPerIP");

                    b.Property<int>("HomeRunsAllowed");

                    b.Property<int>("HomeStrikeOuts");

                    b.Property<decimal>("HomeTotalScore");

                    b.Property<int>("HomeWalks");

                    b.Property<string>("LastName");

                    b.Property<decimal>("LastStartDeviance");

                    b.Property<decimal>("LastStartProjected");

                    b.Property<decimal>("LastStartScore");

                    b.Property<decimal>("LastThreeDeviance");

                    b.Property<int>("LastThreeERA");

                    b.Property<int>("LastThreeHRA");

                    b.Property<int>("LastThreeHitsAllowed");

                    b.Property<decimal>("LastThreeInningsPitched");

                    b.Property<decimal>("LastThreeProjected");

                    b.Property<int>("LastThreeStrikeouts");

                    b.Property<decimal>("LastThreeTotalScore");

                    b.Property<int>("LastThreeWalks");

                    b.Property<string>("MatchUp");

                    b.Property<string>("Opponent");

                    b.Property<decimal>("OpposingTeamProjected");

                    b.Property<int>("PlayerID");

                    b.Property<bool>("ProbableStarter");

                    b.Property<decimal>("ProjectedHRA");

                    b.Property<decimal>("ProjectedHit");

                    b.Property<decimal>("ProjectedRA");

                    b.Property<decimal>("ProjectedStrikeout");

                    b.Property<decimal>("ProjectedWalk");

                    b.Property<int>("Projection");

                    b.Property<int>("Salary");

                    b.Property<decimal>("SeasonEarnedRunsAllowed");

                    b.Property<int>("SeasonHitsAllowed");

                    b.Property<int>("SeasonHomeRunAllowed");

                    b.Property<decimal>("SeasonIp");

                    b.Property<decimal>("SeasonPointsPerIP");

                    b.Property<int>("SeasonRunsAllowed");

                    b.Property<int>("SeasonStrikeOuts");

                    b.Property<decimal>("SeasonTotalScore");

                    b.Property<int>("SeasonWalks");

                    b.Property<int>("SeasonWins");

                    b.Property<string>("TeamName");

                    b.Property<string>("ThrowingHand");

                    b.HasKey("ID");

                    b.ToTable("Pitchers");
                });

            modelBuilder.Entity("LCFinalProject.Models.PositionPlayer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AwayAb");

                    b.Property<decimal>("AwayAvg");

                    b.Property<int>("AwayCs");

                    b.Property<int>("AwayHit");

                    b.Property<int>("AwayHr");

                    b.Property<decimal>("AwayOps");

                    b.Property<int>("AwayRbi");

                    b.Property<int>("AwayRun");

                    b.Property<int>("AwaySb");

                    b.Property<decimal>("AwayScorePerAB");

                    b.Property<decimal>("AwayTotalScore");

                    b.Property<int>("AwayWalk");

                    b.Property<int>("DKID");

                    b.Property<string>("FirstName");

                    b.Property<decimal>("HomeAb");

                    b.Property<decimal>("HomeAvg");

                    b.Property<string>("HomeAway");

                    b.Property<int>("HomeCs");

                    b.Property<int>("HomeHit");

                    b.Property<int>("HomeHr");

                    b.Property<decimal>("HomeOps");

                    b.Property<int>("HomeRbi");

                    b.Property<int>("HomeRun");

                    b.Property<int>("HomeSb");

                    b.Property<decimal>("HomeScorePerAB");

                    b.Property<decimal>("HomeTotalScore");

                    b.Property<int>("HomeWalk");

                    b.Property<int>("LastFiveAb");

                    b.Property<decimal>("LastFiveDeviance");

                    b.Property<int>("LastFiveDouble");

                    b.Property<int>("LastFiveHR");

                    b.Property<int>("LastFiveHit");

                    b.Property<decimal>("LastFiveProjected");

                    b.Property<int>("LastFiveRBI");

                    b.Property<int>("LastFiveRuns");

                    b.Property<int>("LastFiveSB");

                    b.Property<decimal>("LastFiveTotalScore");

                    b.Property<int>("LastFiveTriple");

                    b.Property<int>("LastFiveWalk");

                    b.Property<string>("LastName");

                    b.Property<string>("MatchUp");

                    b.Property<int>("OpponentHRALastThree");

                    b.Property<decimal>("OpponentPointsLastThree");

                    b.Property<string>("OpponentStarter");

                    b.Property<string>("OpponentThrowingHand");

                    b.Property<int>("PlayerID");

                    b.Property<string>("Position");

                    b.Property<decimal>("ProjectedDouble");

                    b.Property<decimal>("ProjectedHR");

                    b.Property<decimal>("ProjectedHit");

                    b.Property<decimal>("ProjectedRBI");

                    b.Property<decimal>("ProjectedRun");

                    b.Property<decimal>("ProjectedSB");

                    b.Property<decimal>("ProjectedTriple");

                    b.Property<decimal>("ProjectedWalk");

                    b.Property<decimal>("Projection");

                    b.Property<int>("Salary");

                    b.Property<decimal>("SeasonAb");

                    b.Property<decimal>("SeasonAvg");

                    b.Property<int>("SeasonCs");

                    b.Property<int>("SeasonDouble");

                    b.Property<int>("SeasonHit");

                    b.Property<int>("SeasonHr");

                    b.Property<decimal>("SeasonOps");

                    b.Property<int>("SeasonRbi");

                    b.Property<int>("SeasonRun");

                    b.Property<int>("SeasonSb");

                    b.Property<int>("SeasonSingle");

                    b.Property<decimal>("SeasonTotalScore");

                    b.Property<int>("SeasonTriple");

                    b.Property<int>("SeasonWalk");

                    b.Property<string>("TeamName");

                    b.Property<decimal>("VsLhpAb");

                    b.Property<decimal>("VsLhpAvg");

                    b.Property<int>("VsLhpCs");

                    b.Property<int>("VsLhpHit");

                    b.Property<int>("VsLhpHr");

                    b.Property<decimal>("VsLhpOps");

                    b.Property<int>("VsLhpRbi");

                    b.Property<int>("VsLhpRun");

                    b.Property<int>("VsLhpSb");

                    b.Property<decimal>("VsLhpScorePerAB");

                    b.Property<decimal>("VsLhpTotalScore");

                    b.Property<int>("VsLhpWalk");

                    b.Property<decimal>("VsRhpAb");

                    b.Property<decimal>("VsRhpAvg");

                    b.Property<int>("VsRhpCs");

                    b.Property<int>("VsRhpHit");

                    b.Property<int>("VsRhpHr");

                    b.Property<decimal>("VsRhpOps");

                    b.Property<int>("VsRhpRbi");

                    b.Property<int>("VsRhpRun");

                    b.Property<int>("VsRhpSb");

                    b.Property<decimal>("VsRhpScorePerAB");

                    b.Property<decimal>("VsRhpTotalScore");

                    b.Property<int>("VsRhpWalk");

                    b.Property<decimal>("YesterdayDeviance");

                    b.Property<decimal>("YesterdayProjected");

                    b.Property<decimal>("YesterdayTotalScore");

                    b.HasKey("ID");

                    b.ToTable("PositionPlayer");
                });

            modelBuilder.Entity("LCFinalProject.Models.ProjectedGame", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("GameDate");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("Projection");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("ProjectedGames");
                });

            modelBuilder.Entity("LCFinalProject.Models.ProjectedTeam", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Catcher");

                    b.Property<decimal>("CatcherProjection");

                    b.Property<int>("CatcherSalary");

                    b.Property<string>("FirstBase");

                    b.Property<decimal>("FirstBaseProjection");

                    b.Property<int>("FirstBaseSalary");

                    b.Property<string>("OutfieldOne");

                    b.Property<decimal>("OutfieldOneProjection");

                    b.Property<int>("OutfieldOneSalary");

                    b.Property<string>("OutfieldThree");

                    b.Property<decimal>("OutfieldThreeProjection");

                    b.Property<int>("OutfieldThreeSalary");

                    b.Property<string>("OutfieldTwo");

                    b.Property<decimal>("OutfieldTwoProjection");

                    b.Property<int>("OutfieldTwoSalary");

                    b.Property<string>("PitcherOne");

                    b.Property<decimal>("PitcherOneProjection");

                    b.Property<int>("PitcherOneSalary");

                    b.Property<string>("PitcherTwo");

                    b.Property<decimal>("PitcherTwoProjection");

                    b.Property<int>("PitcherTwoSalary");

                    b.Property<string>("SecondBase");

                    b.Property<decimal>("SecondBaseProjection");

                    b.Property<int>("SecondBaseSalary");

                    b.Property<string>("Shortstop");

                    b.Property<decimal>("ShortstopProjection");

                    b.Property<int>("ShortstopSalary");

                    b.Property<decimal>("TeamProjection");

                    b.Property<string>("ThirdBase");

                    b.Property<decimal>("ThirdBaseProjection");

                    b.Property<int>("ThirdBaseSalary");

                    b.Property<int>("TotalCost");

                    b.HasKey("ID");

                    b.ToTable("ProjectedTeams");
                });

            modelBuilder.Entity("LCFinalProject.Models.Team", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("GamesPlayedGauge");

                    b.Property<int>("Hits");

                    b.Property<decimal>("HitsAllowed");

                    b.Property<string>("HomeAway");

                    b.Property<int>("HomeRuns");

                    b.Property<decimal>("HomeRunsAllowed");

                    b.Property<string>("Opponent");

                    b.Property<string>("OpponentStarter");

                    b.Property<decimal>("PointsGivenUp");

                    b.Property<decimal>("PointsPerPitcherUsed");

                    b.Property<int>("Runs");

                    b.Property<decimal>("RunsAllowed");

                    b.Property<string>("Starter");

                    b.Property<int>("StrikeOuts");

                    b.Property<string>("TeamName");

                    b.Property<int>("TotalPoints");

                    b.Property<int>("Walks");

                    b.HasKey("ID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("LCFinalProject.Models.TeamGameDate", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("GameDate");

                    b.Property<string>("TeamName");

                    b.HasKey("ID");

                    b.ToTable("TeamGameDates");
                });

            modelBuilder.Entity("LCFinalProject.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LCFinalProject.Models.YesterdayGame", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Directory");

                    b.Property<DateTime>("GameDate");

                    b.Property<int>("GameID");

                    b.Property<string>("Venue");

                    b.Property<int>("VenueID");

                    b.HasKey("ID");

                    b.ToTable("Games");
                });
#pragma warning restore 612, 618
        }
    }
}

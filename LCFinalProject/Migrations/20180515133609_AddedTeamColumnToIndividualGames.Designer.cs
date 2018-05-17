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
    [Migration("20180515133609_AddedTeamColumnToIndividualGames")]
    partial class AddedTeamColumnToIndividualGames
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LCFinalProject.Models.AwayCatcher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("AwayCatchers");
                });

            modelBuilder.Entity("LCFinalProject.Models.AwayFirstBaseman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("AwayFirstBasemen");
                });

            modelBuilder.Entity("LCFinalProject.Models.AwayOutfielder", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("AwayOutfielders");
                });

            modelBuilder.Entity("LCFinalProject.Models.AwayPitcher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("AwayPitchers");
                });

            modelBuilder.Entity("LCFinalProject.Models.AwaySecondBaseman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("AwaySecondBasemen");
                });

            modelBuilder.Entity("LCFinalProject.Models.AwayShortstop", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("AwayShortstops");
                });

            modelBuilder.Entity("LCFinalProject.Models.AwayThirdBaseman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("AwayThirdBasemen");
                });

            modelBuilder.Entity("LCFinalProject.Models.Game", b =>
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

            modelBuilder.Entity("LCFinalProject.Models.HomeCatcher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("HomeCatchers");
                });

            modelBuilder.Entity("LCFinalProject.Models.HomeFirstBaseman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("HomeFirstBasemen");
                });

            modelBuilder.Entity("LCFinalProject.Models.HomeOutfielder", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("HomeOutfielders");
                });

            modelBuilder.Entity("LCFinalProject.Models.HomePitcher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("HomePitchers");
                });

            modelBuilder.Entity("LCFinalProject.Models.HomeSecondBaseman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("HomeSecondBasemen");
                });

            modelBuilder.Entity("LCFinalProject.Models.HomeShortstop", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("HomeShortstops");
                });

            modelBuilder.Entity("LCFinalProject.Models.HomeThirdBaseman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("HomeThirdBasemen");
                });

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

                    b.Property<int>("RunsAllowed");

                    b.Property<int>("StrikeOuts");

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

                    b.Property<int>("PlayerID");

                    b.Property<string>("Position");

                    b.Property<int>("RBI");

                    b.Property<int>("Run");

                    b.Property<int>("Single");

                    b.Property<int>("StolenBase");

                    b.Property<string>("Team");

                    b.Property<decimal>("TotalScore");

                    b.Property<int>("Triple");

                    b.Property<int>("Walk");

                    b.HasKey("ID");

                    b.ToTable("IndividualGamePosPlayers");
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

            modelBuilder.Entity("LCFinalProject.Models.LhpCatcher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("LhpCatchers");
                });

            modelBuilder.Entity("LCFinalProject.Models.LhpFirstBaseman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("LhpFirstBasemen");
                });

            modelBuilder.Entity("LCFinalProject.Models.LhpOutfielder", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("LhpOutfielders");
                });

            modelBuilder.Entity("LCFinalProject.Models.LhpSecondBaseman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("LhpSecondBasemen");
                });

            modelBuilder.Entity("LCFinalProject.Models.LhpShortstop", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("LhpShortstops");
                });

            modelBuilder.Entity("LCFinalProject.Models.LhpThirdBaseman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("LhpThirdBasemen");
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

                    b.Property<int>("AwayRunsAllowed");

                    b.Property<int>("AwayStrikeOuts");

                    b.Property<decimal>("AwayTotalScore");

                    b.Property<int>("AwayWalks");

                    b.Property<int>("DkID");

                    b.Property<string>("FirstName");

                    b.Property<decimal>("HomeEarnedRunsAllowed");

                    b.Property<int>("HomeHitByPitch");

                    b.Property<int>("HomeHitsAllowed");

                    b.Property<int>("HomeHomeRunAllowed");

                    b.Property<decimal>("HomeIp");

                    b.Property<int>("HomeRunsAllowed");

                    b.Property<int>("HomeStrikeOuts");

                    b.Property<decimal>("HomeTotalScore");

                    b.Property<int>("HomeWalks");

                    b.Property<string>("LastName");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("SeasonEarnedRunsAllowed");

                    b.Property<int>("SeasonHitsAllowed");

                    b.Property<int>("SeasonHomeRunAllowed");

                    b.Property<decimal>("SeasonIp");

                    b.Property<int>("SeasonRunsAllowed");

                    b.Property<int>("SeasonStrikeOuts");

                    b.Property<decimal>("SeasonTotalScore");

                    b.Property<int>("SeasonWalks");

                    b.Property<int>("SeasonWins");

                    b.Property<string>("TeamName");

                    b.HasKey("ID");

                    b.ToTable("Pitchers");
                });

            modelBuilder.Entity("LCFinalProject.Models.PositionPlayer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AwayAb");

                    b.Property<decimal>("AwayAvg");

                    b.Property<int>("AwayCs");

                    b.Property<int>("AwayHit");

                    b.Property<int>("AwayHr");

                    b.Property<decimal>("AwayOps");

                    b.Property<int>("AwayRbi");

                    b.Property<int>("AwayRun");

                    b.Property<int>("AwaySb");

                    b.Property<int>("AwayTotalScore");

                    b.Property<int>("AwayWalk");

                    b.Property<string>("FirstName");

                    b.Property<int>("HomeAb");

                    b.Property<decimal>("HomeAvg");

                    b.Property<int>("HomeCs");

                    b.Property<int>("HomeHit");

                    b.Property<int>("HomeHr");

                    b.Property<decimal>("HomeOps");

                    b.Property<int>("HomeRbi");

                    b.Property<int>("HomeRun");

                    b.Property<int>("HomeSb");

                    b.Property<int>("HomeTotalScore");

                    b.Property<int>("HomeWalk");

                    b.Property<string>("LastName");

                    b.Property<int>("PlayerID");

                    b.Property<string>("Position");

                    b.Property<int>("SeasonAb");

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

                    b.Property<int>("SeasonTotalScore");

                    b.Property<int>("SeasonTriple");

                    b.Property<int>("SeasonWalk");

                    b.Property<string>("TeamName");

                    b.Property<int>("VsLhpAb");

                    b.Property<decimal>("VsLhpAvg");

                    b.Property<int>("VsLhpCs");

                    b.Property<int>("VsLhpHit");

                    b.Property<int>("VsLhpHr");

                    b.Property<decimal>("VsLhpOps");

                    b.Property<int>("VsLhpRbi");

                    b.Property<int>("VsLhpRun");

                    b.Property<int>("VsLhpSb");

                    b.Property<int>("VsLhpTotalScore");

                    b.Property<int>("VsLhpWalk");

                    b.Property<int>("VsRhpAb");

                    b.Property<decimal>("VsRhpAvg");

                    b.Property<int>("VsRhpCs");

                    b.Property<int>("VsRhpHit");

                    b.Property<int>("VsRhpHr");

                    b.Property<decimal>("VsRhpOps");

                    b.Property<int>("VsRhpRbi");

                    b.Property<int>("VsRhpRun");

                    b.Property<int>("VsRhpSb");

                    b.Property<int>("VsRhpTotalScore");

                    b.Property<int>("VsRhpWalk");

                    b.HasKey("ID");

                    b.ToTable("PositionPlayers");
                });

            modelBuilder.Entity("LCFinalProject.Models.ProjectedCatcher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("ProjectedScore");

                    b.HasKey("ID");

                    b.ToTable("ProjectedCatchers");
                });

            modelBuilder.Entity("LCFinalProject.Models.ProjectedFirstBaseman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("ProjectedScore");

                    b.HasKey("ID");

                    b.ToTable("ProjectedFirstBasemen");
                });

            modelBuilder.Entity("LCFinalProject.Models.ProjectedOutfielder", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("ProjectedScore");

                    b.HasKey("ID");

                    b.ToTable("ProjectedOutfielders");
                });

            modelBuilder.Entity("LCFinalProject.Models.ProjectedPitcher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("ProjectedScore");

                    b.HasKey("ID");

                    b.ToTable("ProjectedPitchers");
                });

            modelBuilder.Entity("LCFinalProject.Models.ProjectedSecondBaseman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("ProjectedScore");

                    b.HasKey("ID");

                    b.ToTable("ProjectedSecondBasemen");
                });

            modelBuilder.Entity("LCFinalProject.Models.ProjectedShortstop", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("ProjectedScore");

                    b.HasKey("ID");

                    b.ToTable("ProjectedShortstops");
                });

            modelBuilder.Entity("LCFinalProject.Models.ProjectedThirdBaseman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("ProjectedScore");

                    b.HasKey("ID");

                    b.ToTable("ProjectedThirdBasemen");
                });

            modelBuilder.Entity("LCFinalProject.Models.RhpCatcher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("RhpCatchers");
                });

            modelBuilder.Entity("LCFinalProject.Models.RhpFirstBaseman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("RhpFirstBasemen");
                });

            modelBuilder.Entity("LCFinalProject.Models.RhpOutfielder", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("RhpOutfielders");
                });

            modelBuilder.Entity("LCFinalProject.Models.RhpSecondBaseman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("RhpSecondBasemen");
                });

            modelBuilder.Entity("LCFinalProject.Models.RhpShortstop", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("RhpShortstops");
                });

            modelBuilder.Entity("LCFinalProject.Models.RhpThirdBaseman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("PointPerAtBat");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("RhpThirdBasemen");
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

            modelBuilder.Entity("LCFinalProject.Models.YesterdayCatchers", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("YesterdayCatchers");
                });

            modelBuilder.Entity("LCFinalProject.Models.YesterdayFirstBase", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("YesterdayFirstBasemen");
                });

            modelBuilder.Entity("LCFinalProject.Models.YesterdayOutfielder", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("YesterdayOutfielders");
                });

            modelBuilder.Entity("LCFinalProject.Models.YesterdaySecondBase", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("YesterdaySecondBasemen");
                });

            modelBuilder.Entity("LCFinalProject.Models.YesterdayShortstop", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("YesterdayShortstops");
                });

            modelBuilder.Entity("LCFinalProject.Models.YesterdayThirdBase", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("TotalScore");

                    b.HasKey("ID");

                    b.ToTable("YesterdayThirdBasemen");
                });
#pragma warning restore 612, 618
        }
    }
}

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

                    b.Property<int>("HomeWalks");

                    b.Property<string>("LastName");

                    b.Property<int>("PlayerID");

                    b.Property<decimal>("SeasonEarnedRunsAllowed");

                    b.Property<int>("SeasonHitsAllowed");

                    b.Property<int>("SeasonHomeRunAllowed");

                    b.Property<decimal>("SeasonIp");

                    b.Property<int>("SeasonRunsAllowed");

                    b.Property<int>("SeasonStrikeOuts");

                    b.Property<int>("SeasonWalks");

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

                    b.Property<int>("AwayWalk");

                    b.Property<int>("DkID");

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

                    b.Property<int>("VsRhpWalk");

                    b.Property<int>("VsStarterAb");

                    b.Property<decimal>("VsStarterAvg");

                    b.Property<int>("VsStarterCs");

                    b.Property<int>("VsStarterHit");

                    b.Property<int>("VsStarterHr");

                    b.Property<decimal>("VsStarterOps");

                    b.Property<int>("VsStarterRbi");

                    b.Property<int>("VsStarterRun");

                    b.Property<int>("VsStarterSb");

                    b.Property<int>("VsStarterWalk");

                    b.HasKey("ID");

                    b.ToTable("PositionPlayers");
                });

            modelBuilder.Entity("LCFinalProject.Models.ProjectedTeam", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CatcherName");

                    b.Property<int>("CatcherPrice");

                    b.Property<decimal>("CatcherProjectedScore");

                    b.Property<string>("FirstBaseName");

                    b.Property<int>("FirstBasePrice");

                    b.Property<decimal>("FirstBaseProjectScore");

                    b.Property<string>("OutfieldOneName");

                    b.Property<int>("OutfieldOnePrice");

                    b.Property<decimal>("OutfieldOneProjectedScore");

                    b.Property<string>("OutfieldThreeName");

                    b.Property<int>("OutfieldThreePrice");

                    b.Property<decimal>("OutfieldThreeProjectedScore");

                    b.Property<string>("OutfieldTwoName");

                    b.Property<int>("OutfieldTwoPrice");

                    b.Property<decimal>("OutfieldTwoProjectedScore");

                    b.Property<string>("PitcherOneName");

                    b.Property<int>("PitcherOnePrice");

                    b.Property<decimal>("PitcherOneProjectedScore");

                    b.Property<string>("PitcherTwoName");

                    b.Property<int>("PitcherTwoPrice");

                    b.Property<decimal>("PitcherTwoProjectedScore");

                    b.Property<string>("Position");

                    b.Property<decimal>("ProjectedResults");

                    b.Property<string>("SecondBaseName");

                    b.Property<int>("SecondBasePrice");

                    b.Property<decimal>("SecondBaseProjectedScore");

                    b.Property<string>("ShortStopName");

                    b.Property<int>("ShortStopPrice");

                    b.Property<decimal>("ShortStopProjectedScore");

                    b.Property<string>("ThirdBaseName");

                    b.Property<int>("ThirdBasePrice");

                    b.Property<decimal>("ThirdBaseProjectedScore");

                    b.Property<decimal>("TotalProjectedScore");

                    b.Property<int>("TotalTeamPrice");

                    b.HasKey("ID");

                    b.ToTable("ProjectedTeams");
                });

            modelBuilder.Entity("LCFinalProject.Models.Result", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.HasKey("ID");

                    b.ToTable("Results");
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
#pragma warning restore 612, 618
        }
    }
}

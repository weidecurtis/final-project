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
    [Migration("20190528005038_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LCFinalProject.Models.Batter", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AtBats");

                    b.Property<int>("CS");

                    b.Property<decimal>("DistanceAvg");

                    b.Property<int>("Doubles");

                    b.Property<string>("FirstName");

                    b.Property<int>("Hits");

                    b.Property<int>("HomeRuns");

                    b.Property<int>("LastFiveAb");

                    b.Property<int>("LastFiveDouble");

                    b.Property<int>("LastFiveHR");

                    b.Property<int>("LastFiveRBI");

                    b.Property<int>("LastFiveRuns");

                    b.Property<int>("LastFiveSB");

                    b.Property<int>("LastFiveSingle");

                    b.Property<int>("LastFiveTriple");

                    b.Property<int>("LastFiveWalk");

                    b.Property<string>("LastName");

                    b.Property<decimal>("LastTenLaunchAvg");

                    b.Property<decimal>("LastTenSpeedAvg");

                    b.Property<int>("PlayerID");

                    b.Property<int>("RBIs");

                    b.Property<int>("Runs");

                    b.Property<int>("SB");

                    b.Property<string>("TeamName");

                    b.Property<int>("Triples");

                    b.Property<int>("Walks");

                    b.HasKey("ID");

                    b.ToTable("Batters");
                });

            modelBuilder.Entity("LCFinalProject.Models.Game", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("GameDate");

                    b.Property<int>("GameID");

                    b.Property<string>("Venue");

                    b.Property<int>("VenueID");

                    b.HasKey("ID");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("LCFinalProject.Models.GameStat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CS");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Doubles");

                    b.Property<int>("Hits");

                    b.Property<int>("HomeRuns");

                    b.Property<int>("PlayerID");

                    b.Property<int>("RBIs");

                    b.Property<int>("Runs");

                    b.Property<int>("SB");

                    b.Property<int>("Triples");

                    b.Property<int>("Walks");

                    b.HasKey("ID");

                    b.ToTable("GameStats");
                });

            modelBuilder.Entity("LCFinalProject.Models.HitData", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<decimal>("Distance");

                    b.Property<decimal>("LaunchAngle");

                    b.Property<decimal>("LaunchSpeed");

                    b.Property<int>("PlayerID");

                    b.HasKey("ID");

                    b.ToTable("HitDatas");
                });

            modelBuilder.Entity("LCFinalProject.Models.PitchData", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.HasKey("ID");

                    b.ToTable("PitchDatas");
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

            modelBuilder.Entity("LCFinalProject.Models.Team", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TeamName");

                    b.HasKey("ID");

                    b.ToTable("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
